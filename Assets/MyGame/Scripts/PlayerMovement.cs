using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject player;
    //public float speedNegative = -0.1f;
    public float speed = 10f;

    Vector3 movement;

  
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {


        /* if (Input.GetKey(KeyCode.LeftArrow))
         {
             var playerX = gameObject.transform.position.x;
             player.transform.position = new Vector2(playerX + speedNegative, -3.52f);
         }

         if (Input.GetKey(KeyCode.RightArrow))
         {
             var playerX = gameObject.transform.position.x;
             player.transform.position = new Vector2(playerX + speedPositive, -3.52f);


         }*/

        float horizontalInput = Input.GetAxis("Horizontal");
        movement = new Vector3(horizontalInput, 0f, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
        
    }
}
