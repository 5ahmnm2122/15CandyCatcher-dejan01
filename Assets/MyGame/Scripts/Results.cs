using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Results : MonoBehaviour
{
    public Text spielerName;
    public Text punkte;
    public Text resultat;
    public Text highscoreText;

 
    // Start is called before the first frame update
    void Start()
    {
        punkte.text = "Punkte: " + Score.scoreUpdate.ToString();
        spielerName.text = PlayerName.nameOfPlayer;

        if (Score.winOrLoose == 0)
        {
            resultat.text = "Verloren";
            resultat.color = Color.red;
        }
        else
        {
            resultat.text = "Gewonnen";
            resultat.color = Color.green;
        }

        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();


        if(Score.scoreUpdate > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", Score.scoreUpdate);
        }
    }
    
    public void ResetHighscore()
    {
        PlayerPrefs.DeleteKey("Highscore");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("StartScene");
        Score.scoreUpdate = 0;
    }
}
