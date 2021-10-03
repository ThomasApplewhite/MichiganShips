using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradeDeck : Deck
{
    public HorizontalLayoutGroup P1Trade;
    public Deck P1Deck;

    public HorizontalLayoutGroup P2Trade;
    public Deck P2Deck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void FixedUpdate()
    {
        Debug.Log($"{this.gameObject.name}.TradeDeck.FixedUpdate: queue size: {this.deckQueue.Count}");
        if(P1Trade.gameObject.transform.childCount < minimumChildren)
        {
            DrawTradeCard();
        }
    }

    void DrawTradeCard()
    {
        var data = deckQueue.Dequeue();

        var cardA = Instantiate(cardPrefab, P1Trade.transform).GetComponent<TradeCard>();
        var cardB = Instantiate(cardPrefab, P2Trade.transform).GetComponent<TradeCard>();

        cardA.homeDeck = P1Deck;
        cardA.InitializeFromCardData(data);
        cardA.twin = cardB;
        cardA.gameObject.SetActive(true);

        cardB.homeDeck = P2Deck;
        cardB.InitializeFromCardData(data);
        cardB.twin = cardA;
        cardB.gameObject.SetActive(true);
    }
}
