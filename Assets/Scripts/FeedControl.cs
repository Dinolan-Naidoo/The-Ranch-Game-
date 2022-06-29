using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedControl : MonoBehaviour
{
    //Controls feeding sheep 
    public void FeedButton()
    {
        if (Game_Manager.CARROTS > 0)
        {
            Animal_Health.health += 40f;
            Game_Manager.CARROTS -= 1;
        }
    }
}
