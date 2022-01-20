using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerName : MonoBehaviour
{
    public Text playersName;

    public static string nameOfPlayer;

    private void Update()
    {
        nameOfPlayer = playersName.text;
        Debug.Log(nameOfPlayer);
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("MainScene");
    }



}
