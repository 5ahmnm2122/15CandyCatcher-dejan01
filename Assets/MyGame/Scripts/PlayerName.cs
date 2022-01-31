using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerName : MonoBehaviour
{
    public Text playersName;
    public InputField nameInput;
    public Button weiter;
    public Button zurück;

    private void Update()
    {
        PlayerPrefs.SetString("Name", playersName.text);

        if (playersName.text == "")
        {
            InactiveButtons();
        }
    }

    public void OnMouseDown()
    {
        if (playersName.text != "")
        {
            SceneManager.LoadScene("InfoScreen");
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
