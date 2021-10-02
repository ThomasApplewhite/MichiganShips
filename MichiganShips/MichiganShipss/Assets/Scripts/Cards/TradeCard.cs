using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TradeCard : Card
{
    public TradeCard twin { get; set; }

    //To fulfill ISubmitHandler so that pressing "Submit" activates the card
    public override void OnSubmit(BaseEventData eventData)
    {
        FindSelectableOnLeft().Select();
        Buy();
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
