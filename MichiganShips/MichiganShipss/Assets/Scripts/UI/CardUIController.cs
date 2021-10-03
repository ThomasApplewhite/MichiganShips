using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class CardUIController : MonoBehaviour
{

    bool currentlyHandRow;
    public CursorRow cursor;

    [Header("Hand Row")]
    public Deck handRow;

    [Header("Trade Row")]
    public GameObject tradeRow;

    // Start is called before the first frame update
    void Start()
    {
        EnableHandRow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnableHandRow()
    {
        currentlyHandRow = true;
            
        handRow.Activate();
        tradeRow.SetActive(false);
    }

    void EnableTradeRow()
    {
        currentlyHandRow = false;

        handRow.gameObject.SetActive(false);
        tradeRow.SetActive(true);
    }

    public void ActivateCard(InputAction.CallbackContext context)
    {
        //Needs to be added due to a bug with button inputs and prefabs
        if(!context.performed) return;

        Transform activatedCard;
        var cardNum = cursor.cursorPosition;

        //so fucked not even vs code can parse it
        activatedCard = currentlyHandRow ? handRow.transform.GetChild(cardNum) : tradeRow.transform.GetChild(cardNum);

        activatedCard.GetComponent<Card>().Activate(Card.EffectSide.PORT);
    }

    public void SwitchRow(InputAction.CallbackContext context)
    {
        //Needs to be added due to a bug with button inputs and prefabs
        //Technically trade row isn't a prefab but whatever
        if (!context.performed) return;

        if(currentlyHandRow) EnableTradeRow();
        else EnableHandRow();
    }
}
