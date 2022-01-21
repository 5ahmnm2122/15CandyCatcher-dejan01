using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Results : MonoBehaviour
{
    public Text spielerName;
    public Text punkte;
    public Text resultat;

    // Start is called before the first frame update
    void Start()
    {
       punkte.text = "Punkte: " + Score.scoreUpdate.ToString();
       spielerName.text = PlayerName.nameOfPlayer;

        if(Score.winOrLoose == 0)
        {
            resultat.text = "Verloren";
            resultat.color = Color.red;
        }
        else
        {
            resultat.text = "Gewonnen";
            resultat.color = Color.green;
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("StartScene");
        Score.scoreUpdate = 0;
    }

}
