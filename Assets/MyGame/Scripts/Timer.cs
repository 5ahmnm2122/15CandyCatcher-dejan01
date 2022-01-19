using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    int timeUpdate;
    int timeStart;

    void Start()
    {
        for (int i = 60; i > 0; i--) {
            timeUpdate = timeStart - 1;
            timeStart = timeStart - 1;
            Debug.Log(timeUpdate);


        }
    }

}
