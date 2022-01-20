using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text timeText;


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
        
    }


    

}
