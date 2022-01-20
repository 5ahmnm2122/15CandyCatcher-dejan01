using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public Text spielerName;
    public Text punkte;
    public Text resultat;

    // Start is called before the first frame update
    void Start()
    {
       punkte.text = Score.scoreUpdate.ToString();
       spielerName.text = PlayerName.nameOfPlayer;
    }

}
