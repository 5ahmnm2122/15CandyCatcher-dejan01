using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio; 

public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text timeText;
    public AudioSource tenSecondsAudio;


    void Update()
    {
        if(timeStart < 61)
        {
            timeStart -= Time.deltaTime;
        }

        int timeUpdate = (int) timeStart;
        timeText.text = timeUpdate.ToString();
        
        if(timeStart < 1)
        {
            SceneManager.LoadScene("EndScene");
           
        }

        if(timeStart < 1 && Score.scoreUpdate >= 1)
        {
            Score.winOrLoose = 1; //1 bedeutet gewonnen
            Debug.Log("gewonnen");
        }

        if(timeStart < 11)
        {
            timeText.color = Color.red;
            PlayMusic();
        }
        
    }

    void PlayMusic()
    {
        tenSecondsAudio.Play();

    }




}
