using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    //Adds 1 to money amount when coin is clicked
    private void OnMouseDown()
    {
        Game_Manager.moneyAmount += 1;
        Destroy(gameObject);
    }
}
