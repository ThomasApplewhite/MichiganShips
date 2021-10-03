using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TradeCard : Card
{
    public TradeCard twin { get; set; }
    public ShipController buyer { get; set; }

    public override void Activate(EffectSide side)
    {
        if(buyer.dubloons >= sourceData.dubloonCost)
        {
            buyer.dubloons -= sourceData.dubloonCost;
            Buy();
        }
    }

    void Buy()
    {
        //homeDeck = this.gameObject.transform.parent.gameObject.
        Debug.Log($"{this.gameObject.name}.TradeCard.Buy: bought");
        homeDeck.DiscardCard(sourceData);
        Destroy(twin.gameObject);
        Destroy(this.gameObject);
    }


}
