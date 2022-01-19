using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayCandy : MonoBehaviour
{


    public GameObject candyOriginal;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjectCandy", 0, 2);
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

    void SpawnObjectCandy()
    {
        Instantiate(candyOriginal, GetSpawnPoint(), Quaternion.identity);
    
    }
}
