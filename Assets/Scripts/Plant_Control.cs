using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant_Control : MonoBehaviour
{
    //Sprites
    public Sprite noPlantObj;
    public Sprite watermelon1;
    public Sprite watermelon2;
    public Sprite potatoe1;
    public Sprite potatoe2;
    public Sprite carrot1;
    public Sprite carrot2;

    //Variables & public references
    public float growTime = 0f;
    public Transform plotObj;
    public string watered = "n";
    public string currentSeed="";
    public AudioSource plantGrownFX;

    void Start()
    {
        watered = "n";
    }

    void Update()
    {
        //Increases grow time
        if (currentSeed!= "")
        {
            growTime += Time.deltaTime;
        }

        //Plant dies if not watered
        if ((growTime > 10) && (watered == "n"))
        {
            GetComponent<SpriteRenderer>().sprite = noPlantObj;
            currentSeed = "";
            growTime = 0;
        }

        //Plant grows if watered
        if ((growTime > 10) && (watered == "y"))
        {
            if (currentSeed == "watermelon")
            {
                GetComponent<SpriteRenderer>().sprite = watermelon2;
            }
            if (currentSeed == "carrot")
            {
                GetComponent<SpriteRenderer>().sprite = carrot2;
            }

            if (currentSeed == "potatoe")
            {
                GetComponent<SpriteRenderer>().sprite = potatoe2;
            }
        }
    }

    private void OnMouseDown()
    {
       
        //If chopper selected -> Weeds can be cut.
        if(Game_Manager.currentTool == "Chopper")
        {
            GetComponent<SpriteRenderer>().sprite = noPlantObj;
        }

        //If watermelon seeds selected -> Watermelon can be planted
        if ((Game_Manager.currentTool == "watermelon") && (GetComponent<SpriteRenderer>().sprite == noPlantObj))
        {  
            if (Game_Manager.watermelonSeeds > 0)
            {
                Game_Manager.watermelonSeeds -= 1;
                GetComponent<SpriteRenderer>().sprite = watermelon1;
                currentSeed = "watermelon";
            }
        }

        //If carrot seeds selected -> Carrot can be planted
        if ((Game_Manager.currentTool == "carrot") && (GetComponent<SpriteRenderer>().sprite == noPlantObj))
        {
            if (Game_Manager.CarrotSeeds > 0)
            {
                Game_Manager.CarrotSeeds -= 1;
                GetComponent<SpriteRenderer>().sprite = carrot1;
                currentSeed = "carrot";
            }
        }

        //If potatoe seeds selected -> Potatoe can be planted
        if ((Game_Manager.currentTool == "potatoe") && (GetComponent<SpriteRenderer>().sprite == noPlantObj))
        {
            if (Game_Manager.PotatoeSeeds > 0)
            {
                GetComponent<SpriteRenderer>().sprite = potatoe1;
                currentSeed = "potatoe";
                Game_Manager.PotatoeSeeds -= 1;
            }       
        }

        //If bucket selected -> Plants can be watered
        if ((Game_Manager.currentTool == "Bucket")&& (GetComponent<SpriteRenderer>().sprite == watermelon1))
        { 
                plotObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);
                watered = "y";
                growTime = 0;
        }

        //Harvesting Watermelon
        if((GetComponent<SpriteRenderer>().sprite == watermelon2))
        {
            Game_Manager.WATERMELON += 1;
            GetComponent<SpriteRenderer>().sprite = noPlantObj;
            watered = "n";
            plotObj.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.23f, 0.23f);
            plantGrownFX.Play();
        }

        //Harvesting Potatoe
        if ((GetComponent<SpriteRenderer>().sprite == potatoe2))
        {
            Game_Manager.POTATOES += 1;
            GetComponent<SpriteRenderer>().sprite = noPlantObj;
            watered = "n";
            plotObj.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.23f, 0.23f);
            plantGrownFX.Play();
        }

        //Harvesting Carrot
        if ((GetComponent<SpriteRenderer>().sprite == carrot2))
        {
            Game_Manager.CARROTS += 1;
            GetComponent<SpriteRenderer>().sprite = noPlantObj;
            watered = "n";
            plotObj.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.23f, 0.23f);
            plantGrownFX.Play();
        }
    } 
}
