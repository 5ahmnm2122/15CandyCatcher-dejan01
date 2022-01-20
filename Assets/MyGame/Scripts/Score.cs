using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public GameObject candy;
    public GameObject bombe;
    public GameObject player;
    int score = 0;

    //public Collider2D col;


   
    void Start()
    {
        scoreText.text = "Score: ";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Health"))
        {
            Debug.Log("geht");
            score++;

            scoreText.text = "Score: " + score.ToString();
        }
        
        
    }

    
}
