using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerName : MonoBehaviour
{
    public Text playersName;
    public InputField nameInput;
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
