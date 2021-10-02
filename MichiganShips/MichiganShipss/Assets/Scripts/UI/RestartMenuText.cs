using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartMenuText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Text>().text = $"{SceneSwitcher.previousLoser} was Defeated!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
