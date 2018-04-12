using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
   
    public float climbingSpeed = 8f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.W))

        {

            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, climbingSpeed);
        }

        else if (other.tag == "Player" && Input.GetKey(KeyCode.S))

        {

            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -climbingSpeed);
        }

        else
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1.20638f);

        }

    
    }
}
