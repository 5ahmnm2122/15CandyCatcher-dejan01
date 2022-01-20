using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    public Text playersName;
 
    int scoreUpdate;


   
    void Start()
    {
        scoreText.text = "Score: ";
        Invoke("StartGameOver", 5f);

        playersName.text = PlayerName.nameOfPlayer;


        Debug.Log(PlayerName.nameOfPlayer);
    }

    //Ermöglicht, dass zu Beginn Game Over Screen nicht aufploppt, weil am Anfang score = 0
    void StartGameOver()
    {
        if (scoreUpdate < 1)
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
            //Debug.Log("collision");
            StartGameOver();
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
           
            scoreUpdate = scoreUpdate - 2;

            scoreText.text = "Score: " + scoreUpdate.ToString();
        }



    }

    
}
