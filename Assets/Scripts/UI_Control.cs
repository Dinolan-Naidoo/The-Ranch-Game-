using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Control : MonoBehaviour
{
    //References to Transforms
    public Transform cursorObj;
    public Transform seedInvObj;
    public Transform CursorObj2;

    private void OnMouseDown()
    {
        //Moves seed inventory out of camera view
        if(gameObject.name == "Chopper")
        {
            Game_Manager.currentTool = "Chopper";
            seedInvObj.transform.position = new Vector2(6.2f, -13f);
            CursorObj2.transform.position = new Vector2(6.2f, -13f);
        }

        //Moves seed inventory into camera view
        if (gameObject.name == "Seeds")
        {
            Game_Manager.currentTool = "Seeds";
            seedInvObj.transform.position = new Vector2(7.5f, -6f);
            CursorObj2.transform.position = new Vector2(7.5f, -12f);
        }

        //Moves seed inventory out of camera view
        if (gameObject.name == "Bucket")
        {
            Game_Manager.currentTool = "Bucket";
            seedInvObj.transform.position = new Vector2(6.2f, -13f);
            CursorObj2.transform.position = new Vector2(6.2f, -13f);
        }

        //Moves cursor to selected tool
        cursorObj.transform.position = transform.position;
        Debug.Log(Game_Manager.currentTool);
    }
}
    

