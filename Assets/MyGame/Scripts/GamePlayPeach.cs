using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayPeach : MonoBehaviour
{
    public GameObject peachOriginal;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjectPeach", 2, 5);
    }


    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-6, 6);

        return new Vector2(x, 8);

    }

    void SpawnObjectPeach()
    {
        Instantiate(peachOriginal, GetSpawnPoint(), Quaternion.identity);

    }
}
