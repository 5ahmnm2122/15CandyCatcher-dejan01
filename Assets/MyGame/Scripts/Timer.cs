using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text timeText;

    public AudioSource tenSecondsAudio;
  


    void Update()
    {
        //Countdown
        if(timeStart < 61)
        {
            timeStart -= Time.deltaTime;
        }

        int timeUpdate = (int) timeStart;
        timeText.text = "Time: " + timeUpdate.ToString();

        //Szenenwechsel End Scene
        if(timeStart < 1)
        {
            SceneManager.LoadScene("EndScene");
           
        }

        //Überprüfen, ob Score 0 ist --> gewonnen, falls wahr
        if(timeStart < 1 && Score.scoreUpdate >= 1)
        {
            Score.winOrLoose = 1; //1 bedeutet gewonnen
        }

        //Score rot einfärben, letzten 10 sek
        if(timeUpdate < 11)
        {
            timeText.color = Color.red;
        }
    }


    //Audio für die letzten 
    private void Start()
    {
        Invoke("PlayAudio", 48.5f);

    }

    void PlayAudio()
    {
        tenSecondsAudio.Play();
    }

    
}
