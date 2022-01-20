using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    /*public GameObject candy;
    public GameObject bombe;
    public GameObject player;*/
    int scoreStart = 0;
    int scoreUpdate;


   
    void Start()
    {
        scoreText.text = "Score: ";
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(scoreUpdate);

        if(scoreUpdate < 1)
        {
            //Game Over
            Debug.Log("GameOver");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Bei Collision mit Candy, +1 Score
        if(collision.gameObject.CompareTag("Health"))
        {
         
            scoreUpdate = scoreUpdate + 1;

            scoreText.text = "Score: " + scoreUpdate.ToString();
        }


        //Bei Collision mit Bombe, game over
        if (collision.gameObject.CompareTag("Death"))
        {
            //SZENENWECHSEL
            scoreUpdate = scoreUpdate - 100;

            scoreText.text = "Score: " + scoreUpdate.ToString();
        }

        if (collision.gameObject.CompareTag("Peach"))
        {
       
            scoreUpdate = scoreUpdate + 4;

            scoreText.text = "Score: " + scoreUpdate.ToString();
        }

        if (collision.gameObject.CompareTag("Worm"))
        {
           
            scoreUpdate = scoreUpdate - 5;

            scoreText.text = "Score: " + scoreUpdate.ToString();
        }



    }

    
}
