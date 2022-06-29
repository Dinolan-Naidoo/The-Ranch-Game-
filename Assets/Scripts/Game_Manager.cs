using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public Transform grassObj;
    public static string currentTool = "none";
    public static int watermelonSeeds = 2;
    public static int PotatoeSeeds = 1;
    public static int CarrotSeeds = 2;
    public static int WATERMELON = 0;
    public static int POTATOES = 0;
    public static int CARROTS = 0;
    public static int moneyAmount;
    public GameObject AnimalPrefab;
    public Text moneyAmountText;
    public Button InstantiateSheep;
    public AudioSource BGMusic;

    void Start()
    {
        //Creates field using grass object
        for (int xPos = -16; xPos < 16; xPos += 2)
        {
            for(int yPos = 9; yPos > -9; yPos -= 2)
            {
                Instantiate(grassObj, new Vector2(xPos, yPos), grassObj.rotation);
            }
        }

        //Tracks money amount
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        //Plays background music
        BGMusic.Play();
    }

    void Update()
    {
        //Money text update
        moneyAmountText.text = "Money : $" + moneyAmount.ToString() ;
        
        
        //Checks whether player can afford sheep
        if ((moneyAmount >= 5))
        {
            InstantiateSheep.interactable = true;
        }
        else
        {
            InstantiateSheep.interactable = false;
        }
    }

    //Loads Main Menu 
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Adds sheep to the den
    public void AnimalBorn()
    {
        moneyAmount -= 5;
        Instantiate(AnimalPrefab, new Vector2(-10, 0), AnimalPrefab.transform.rotation);
    }

}
