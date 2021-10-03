using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public string ownerShip;
    ShipController owner;

    public int minimumChildren = 5;

    public GameObject cardPrefab;

    public List<CardData> startingCards; 

    protected Queue<CardData> deckQueue;

    void Awake()
    {
        Deck.Shuffle(startingCards);
        deckQueue = new Queue<CardData>(startingCards);
        Debug.Log($"{this.gameObject.name}.Deck.Awake: done Shuffling!");
    }
    
    //Fisher-Yates Shuffle from https://stackoverflow.com/questions/273313/randomize-a-listt
    //but it uses unity's random, which is somewhat better
    static void Shuffle(List<CardData> datas)
    {
        int n = datas.Count;
        while(n > 1)
        {
            --n;
            //We don't need to add an extra 1 because unity's random is max inclusive
            int k = UnityEngine.Random.Range(0, n);
            var val = datas[k];
            datas[k] = datas[n];
            datas[n] = val;
        }
    }

    public void Activate()
    {
        this.gameObject.SetActive(true);
        
        if(this.gameObject.transform.childCount == 0)
        {
            GenerateCard();
        }
    }

    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        if(this.gameObject.transform.childCount < minimumChildren)
        {
            GenerateCard();
        }
    }

    void GenerateCard()
    {
        DrawCard().transform.SetParent(this.gameObject.transform);
    }

    public GameObject DrawCard()
    {
        var data = deckQueue.Dequeue();
        var card = Instantiate(cardPrefab).GetComponent<Card>();
        card.homeDeck = this;
        card.InitializeFromCardData(data);
        card.gameObject.SetActive(true);
        return card.gameObject;
    }

    public void DiscardCard(CardData discard)
    {
        deckQueue.Enqueue(discard);
    }
}
