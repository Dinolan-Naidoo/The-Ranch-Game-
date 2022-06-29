using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Move : MonoBehaviour
{
    public float speed;
    public Transform[] movespots;
    public int randomSpots;
    public Transform animal;
    Vector3 LastPos;
    float Threshold = 0.0f;

    private void Start()
    {
        //Find random spot
        randomSpots = Random.Range(0, movespots.Length);
        //Track position
        LastPos = animal.position;
    }

    private void Update()
    {
        SheepMove();

        //Controls sheep sprite rotation according to vector movement
        Vector3 offset = animal.position - LastPos;
        if (offset.x>Threshold)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            LastPos = animal.position;
        }

        else if (offset.x < -Threshold)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            LastPos = animal.position;
            
        }
    }

    //Moves animal to random spot ; Once at random spot -> moves animal to new random spot
    public void SheepMove()
    {
        transform.position = Vector2.MoveTowards(transform.position, movespots[randomSpots].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, movespots[randomSpots].position) < 0.3f)
        {
            randomSpots = Random.Range(0, movespots.Length);
        }
    }


    
    
}
