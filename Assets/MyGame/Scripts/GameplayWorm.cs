using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayWorm : MonoBehaviour
{
    public GameObject wormOriginal;

    public static GameObject objectToDestroy;

    void Start()
    {
   
        InvokeRepeating("SpawnObjectWorm", 4, 6);
    }


    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-7, 7);

        return new Vector2(x, 8);

    }

    void SpawnObjectWorm()
    {
        //clone
        Instantiate(wormOriginal, GetSpawnPoint(), Quaternion.identity);
        
    }

  

   
}
