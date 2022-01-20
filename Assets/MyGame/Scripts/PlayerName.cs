using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerName : MonoBehaviour
{
    public Text playersName;
    public InputField nameInput;

    public static string nameOfPlayer;


    private void Update()
    {
        nameOfPlayer = playersName.text;


    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("MainScene");
    }


    public void Reset()
    {

        var InputField = nameInput.GetComponent<InputField>();
        InputField.text = "";
  
    }


}
