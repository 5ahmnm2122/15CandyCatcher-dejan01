using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{


    public GameObject candyOriginal;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
       
    }


    /*void CloneCandys(int candyNumber){
        for(int i = 0; i < candyNumber; i++)
        {
            GameObject CandyClone = Instantiate(candyCloneOriginal, Random.Range(30, 50));
        }

    }*/

    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-7, 7);

        return new Vector2(x, 8);

    }

    void SpawnObject()
    {
        Instantiate(candyOriginal, GetSpawnPoint(), Quaternion.identity); 
    }
}
