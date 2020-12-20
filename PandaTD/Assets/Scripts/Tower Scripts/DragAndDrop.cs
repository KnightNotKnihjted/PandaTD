using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public bool selected;
    public bool anchored;

    void Update(){
        if(selected == true && anchored == false){
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
        }
        if(Input.GetMouseButtonUp(0) && selected == true && anchored == false){
            selected = false;
            anchored = true;
            
            selected = false;
        }
        if(Input.GetKey(KeyCode.K)){
            selected =! selected;
        }
    }

    void OnMouseOver(){
        if(Input.GetMouseButtonDown(0) && anchored == false){
            selected = true;
        }
    }
}