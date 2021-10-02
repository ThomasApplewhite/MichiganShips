using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUIController : MonoBehaviour
{
    public bool handRowFirst = true;
    bool currentlyHandRow;

    [Header("Hand Row")]
    public Hand handRow;

    [Header("Trade Row")]
    public GameObject tradeRow;
    public Selectable tradeRowFirstSelected;

    // Start is called before the first frame update
    void Start()
    {
        if(handRowFirst) EnableHandRow();
        else EnableTradeRow();
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

        tradeRowFirstSelected.Select();
    }

    public void SwitchRow()
    {
        if(currentlyHandRow) EnableTradeRow();
        else EnableHandRow();
    }
}
