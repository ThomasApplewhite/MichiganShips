using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUIController : MonoBehaviour
{

    bool currentlyHandRow;

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

        tradeRow.transform.GetChild(0).gameObject.GetComponent<Card>().Select();
    }

    public void SwitchRow()
    {
        if(currentlyHandRow) EnableTradeRow();
        else EnableHandRow();
    }
}
