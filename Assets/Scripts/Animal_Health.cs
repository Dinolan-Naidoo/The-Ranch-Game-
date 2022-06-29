using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal_Health : MonoBehaviour
{
    
    public Transform animal;
    public static float health = 120f ;
    public float timeForMoney;
    public GameObject coins;
    float next_spawn_time;
    public GameObject hungryImage;

    void Start()
    {
        //Setting health
        health = 120f;

        //Spawn time for coins
        next_spawn_time = Time.deltaTime + 25.0f;

        //Deactivate hungry image
        hungryImage.SetActive(false);
    }

    void Update()
    {
       
        // Decrement health 
        //Instantiate coins every 25 seconds
        //Activate hungry image if the sheep has less than 40f health
        if (health > 0)
        {
            health -= 1*Time.deltaTime;
            if(health < 40f)
            {
                hungryImage.SetActive(true);
            }
            else
            {
                hungryImage.SetActive(false);
            }

            if (Time.time > next_spawn_time)
            {
                InstantiateMoney();
                next_spawn_time += 25.0f;
            }

            
            
        }

        //Sheep death
        if(health < 0)
        {
            Destroy(gameObject);
        }

    }

    //Spawns coins 
    public void InstantiateMoney()
    {
        Instantiate(coins, animal.transform.position, animal.transform.rotation);
    }

}
