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

    public CardData needMoreCardsCard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void FixedUpdate()
    {
        if(P1Trade.gameObject.transform.childCount < minimumChildren)
        {
            DrawTradeCard();
        }
    }

    void DrawTradeCard()
    {
        CardData data = deckQueue.Count > 0 ? deckQueue.Dequeue() : (CardData) needMoreCardsCard.Clone();

        var cardA = Instantiate(cardPrefab, P1Trade.transform).GetComponent<TradeCard>();
        var cardB = Instantiate(cardPrefab, P2Trade.transform).GetComponent<TradeCard>();

        cardA.homeDeck = P1Deck;
        cardA.buyer = P1Deck.owner;
        cardA.InitializeFromCardData(data);
        cardA.twin = cardB;
        cardA.gameObject.SetActive(true);

        cardB.homeDeck = P2Deck;
        cardB.buyer = P2Deck.owner;
        cardB.InitializeFromCardData(data);
        cardB.twin = cardA;
        cardB.gameObject.SetActive(true);
    }
}
