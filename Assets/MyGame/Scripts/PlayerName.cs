using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerName : MonoBehaviour
{
    public Text playersName;
    public InputField nameInput;
    public Text placeholder;
    public Text Limit;
    public Button weiter;
    public Button zurück;
 

    public static string nameOfPlayer;


    private void Update()
    {
        nameOfPlayer = playersName.text;

        if (playersName.text == "")
        {
            InactiveButtons();
        }

        if (nameInput.characterLimit == 15)
        {
            Limit.text = "Zeichen Limit erreicht!";
            Debug.Log("erreicht");
        }
    }

    public void OnMouseDown()
    {
        if (playersName.text != "")
        {
            SceneManager.LoadScene("MainScene");
        }

      
    }

    
    public void Reset()
    {

        var InputField = nameInput.GetComponent<InputField>();
        InputField.text = "";
  
    }

    public void InactiveButtons()
    {
        weiter.interactable = false;
        zurück.interactable = false;
    }

}
