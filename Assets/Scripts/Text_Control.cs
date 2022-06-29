using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Control : MonoBehaviour
{
    //Reference to cursor
    public Transform CursorObj2;

    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    void Update()
    {
        //Tracks watermelon seeds available
        if(gameObject.name == "WatermelonText")
        {
            GetComponent<TextMesh>().text = "Watermelon Seeds : " + Game_Manager.watermelonSeeds;
        }

        //Tracks potatoe seeds available
        if (gameObject.name == "PotatoeText")
        {
            GetComponent<TextMesh>().text = "Potatoe Seeds : " + Game_Manager.PotatoeSeeds;
        }

        //Tracks carrot seeds available
        if (gameObject.name == "CarrotText")
        {
            GetComponent<TextMesh>().text = "Carrot Seeds : " + Game_Manager.CarrotSeeds;
        }

        //Tracks watermelon available
        if (gameObject.name == "Watermelon")
        {
            GetComponent<TextMesh>().text = "Watermelon : " + Game_Manager.WATERMELON;
        }

        //Tracks potatoes available
        if (gameObject.name == "Potatoes")
        {
            GetComponent<TextMesh>().text = "Potatoes : " + Game_Manager.POTATOES;
        }

        //Tracks carrots available
        if (gameObject.name == "Carrots")
        {
            GetComponent<TextMesh>().text = "Carrots : " + Game_Manager.CARROTS;
        }
    }

    //Moves cursor to the correct selected seed
    private void OnMouseDown()
    {
        if (gameObject.name == "WatermelonText")
        {
            Game_Manager.currentTool = "watermelon";
            CursorObj2.transform.position = transform.position;
        }

        if (gameObject.name == "PotatoeText")
        {
            Game_Manager.currentTool = "potatoe";
            CursorObj2.transform.position = transform.position;
        }

        if (gameObject.name == "CarrotText")
        {
            Game_Manager.currentTool = "carrot";
            CursorObj2.transform.position = transform.position;
        }
    }
}
