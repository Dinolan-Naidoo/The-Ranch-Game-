using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop_Control : MonoBehaviour
{
    //Text references
    public Text moneyAmountText;
    public Text seedAmountWatermelon;
    public Text seedAmountCarrot;
    public Text seedAmountPotatoe;
    public Text Watermelon;
    public Text Carrots;
    public Text Potatoes;

    //Buy Buttons
    public Button buyButton_Watermelon;
    public Button buyButton_Carrot;
    public Button buyButton_Potatoe;
    
    //Sell Buttons
    public Button sellButton_Watermelon;
    public Button sellButton_Carrot;
    public Button sellButton_Potatoe;

    void Start()
    {
        //Purchase text
        seedAmountWatermelon.text = "3 Watermelon seeds [Price: $5]";
        seedAmountCarrot.text = "3 Carrot seeds     [Price: $3]";
        seedAmountPotatoe.text = "3 Potatoe seeds    [Price: $2]";
        
        //Sell text
        Watermelon.text = "2 Watermelon [Earn $10]";
        Carrots.text = "4 Carrots [Earn: $15]";
        Potatoes.text = "3 Potatoes [Earn: $12]";
    }

    void Update()
    {
        //Money text update
        moneyAmountText.text = "Money :$" + Game_Manager.moneyAmount.ToString() ;

        //Watermelon buy
        if ((Game_Manager.moneyAmount >= 5))
        {
            buyButton_Watermelon.interactable = true;

        }
        else
        {
            buyButton_Watermelon.interactable = false;
        }

        //Carrot Buy
        if ((Game_Manager.moneyAmount >= 3))
        {
            buyButton_Carrot.interactable = true;

        }
        else
        {
            buyButton_Carrot.interactable = false;
        }

        //Potatoe Buy
        if ((Game_Manager.moneyAmount >= 2))
        {
            buyButton_Potatoe.interactable = true;

        }
        else
        {
            buyButton_Potatoe.interactable = false;
        } 

        //Watermelon sell
        if (Game_Manager.WATERMELON>=2)
        {
            sellButton_Watermelon.interactable = true;

        }
        else
        {
            sellButton_Watermelon.interactable = false;
        }

        //Carrot sell
        if (Game_Manager.CARROTS >= 4)
        {
            sellButton_Carrot.interactable = true;

        }
        else
        {
            sellButton_Carrot.interactable = false;
        }

        //Potatoe sell
        if (Game_Manager.POTATOES >= 3)
        {
            sellButton_Potatoe.interactable = true;

        }
        else
        {
            sellButton_Potatoe.interactable = false;
        }
    }


    //Functions to control shop buttons
    public void BuyWatermelon()
    {
        Game_Manager.moneyAmount -= 5;
        Game_Manager.watermelonSeeds += 3;
        
    }

    public void BuySeedCarrot()
    {
        Game_Manager.moneyAmount -= 3;
        Game_Manager.CarrotSeeds += 3;
    }

    public void BuySeedPotatoe()
    {
        Game_Manager.moneyAmount -= 2;
        Game_Manager.PotatoeSeeds += 3;
    }

    public void SellWatermelon()
    {
        Game_Manager.moneyAmount += 10;
        Game_Manager.WATERMELON -= 2;
    }

    public void SellCarrot()
    {
        Game_Manager.moneyAmount += 15;
        Game_Manager.CARROTS -= 4;
    }

    public void SellPotatoes()
    {
        Game_Manager.moneyAmount += 12;
        Game_Manager.POTATOES -= 3;
    }
}
