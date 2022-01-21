using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText;

    
    public Text playersName;
 
    public static int scoreUpdate = 0;

    public static int winOrLoose;

   
    void Start()
    {
        scoreText.text = "Score: " + scoreUpdate;
        playersName.text = PlayerName.nameOfPlayer;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       

        //Bei Collision mit Bombe, game over
        if (collision.gameObject.CompareTag("Death"))
        {

            SceneManager.LoadScene("EndScene");

            scoreText.text = "Score: " + scoreUpdate.ToString();
            winOrLoose = 0;
            scoreUpdate = 0;

    
        }


        if (collision.gameObject.CompareTag("Peach"))
        {
       
            scoreUpdate = scoreUpdate + 4;

            scoreText.text = "Score: " + scoreUpdate.ToString();
            
        }


        //Bei Collision mit Candy, +1 Score
        if(collision.gameObject.CompareTag("Health"))
        {
         
            scoreUpdate = scoreUpdate - 1;

            scoreText.text = "Score: " + scoreUpdate.ToString();
            //Debug.Log("collision");
  
        }



        if (collision.gameObject.CompareTag("Worm"))
        {
           
            scoreUpdate = scoreUpdate - 2;

            scoreText.text = "Score: " + scoreUpdate.ToString();
        }


       /* if (other.tag = "Worm" ||)
        {
            Destroy(gameObject);

            
        }*/

        

    }

    

    public void Update()
    {
        if (scoreUpdate < - 20)
        {
  
            SceneManager.LoadScene("EndScene");
            Debug.Log("GameOver");
            winOrLoose = 0; //0 bedeutet verloren
        }


    }



}
