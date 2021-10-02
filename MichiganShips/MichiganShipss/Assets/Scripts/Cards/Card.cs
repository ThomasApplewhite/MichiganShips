using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Card : Selectable, ISubmitHandler
{
    public enum RowState
    {
        HAND,
        TRADE
    }

    public enum EffectSide
    {
        PORT,
        STARBOARD
    }

    [Header("Card Settings")]
    public RowState startingState;

    [Header("Initialization Layout")]
    public Text titleText;
    public Text captionText;
    public Text costText;

    public Text dubloonText;
    public Text deckText;
    public Text broadsideText;

    CardData sourceData;

    //public GameObject LeftRightSelectorPrefab;

    public Deck homeDeck { get; set; }

    public void InitializeFromCardData(CardData data)
    {
        titleText.text = data.cardName;
        captionText.text = data.cardText;
        costText.text = data.dubloonCost.ToString();
        
        dubloonText.text = data.dubloonGain.ToString();
        deckText.text = data.deckGunShots.ToString();
        broadsideText.text = data.broadsides.ToString();
    
        sourceData = data;
    }

    //To fulfill ISubmitHandler so that pressing "Submit" activates the card
    public void OnSubmit(BaseEventData eventData)
    {
        FindSelectableOnLeft().Select();
        Activate(EffectSide.PORT);
    }

    /*public void ActivatePort()
    {
        Activate(EffectSide.PORT);
    }

    public void ActivateStarboard()
    {
        Activate(EffectSide.STARBOARD);
    }*/

    protected virtual void Activate(EffectSide side)
    {
        Debug.Log($"{this.gameObject.name}.Card.Activate: activated on {side} side");
        homeDeck.DiscardCard(sourceData);
        Destroy(this.gameObject);
    }
}
