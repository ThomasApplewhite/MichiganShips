using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class CursorRow : MonoBehaviour
{
    public int cursorPosition { get; set; } = 0;
    Transform rowTrans;

    // Start is called before the first frame update
    void Start()
    {
        //Item 0 should stay on
        rowTrans = this.gameObject.transform;
        for(int i = 1; i < rowTrans.childCount; ++i)
        {
            rowTrans.GetChild(i).gameObject.GetComponent<Image>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCursor(InputAction.CallbackContext context)
    {
        var result = context.ReadValue<Vector2>();
        Debug.Log($"{this.gameObject.name}.CursorRow.MoveCursor: recieved input");
        if(result.x < 0) MoveCursorLeft();
        else MoveCursorRight();
    }

    public void MoveCursorLeft()
    {
        UpdateCursor(cursorPosition-1);
    }

    public void MoveCursorRight()
    {
        UpdateCursor(cursorPosition+1);
    }

    void UpdateCursor(int newPosition)
    {
        //double ternary, go fuck yourself
        newPosition = newPosition < 0 ? rowTrans.childCount - 1 : (newPosition >= rowTrans.childCount ? 0 : newPosition);

        rowTrans.GetChild(cursorPosition).gameObject.GetComponent<Image>().enabled = false;
        rowTrans.GetChild(newPosition).gameObject.GetComponent<Image>().enabled = true;

        cursorPosition = newPosition;
    }


}
