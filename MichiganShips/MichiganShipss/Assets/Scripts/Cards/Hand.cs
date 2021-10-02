using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.HorizontalLayoutGroup))]
public class Hand : MonoBehaviour
{
    public Deck sourceDeck;
    public int minimumChildren = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Activate()
    {
        this.gameObject.SetActive(true);
        
        if(this.gameObject.transform.childCount == 0)
        {
            GenerateCard();
        }

        this.gameObject.transform.GetChild(0).GetComponent<Card>().Select();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(this.gameObject.transform.childCount < minimumChildren)
        {
            GenerateCard();
        }
    }

    void GenerateCard()
    {
        sourceDeck.DrawCard().transform.SetParent(this.gameObject.transform);
    }
}

