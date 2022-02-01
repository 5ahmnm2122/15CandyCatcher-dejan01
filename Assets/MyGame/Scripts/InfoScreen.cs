using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoScreen : MonoBehaviour
{

    public void LadeSpielSzene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void NamenÄndern()
    {
        SceneManager.LoadScene("StartScene");
    }
}
