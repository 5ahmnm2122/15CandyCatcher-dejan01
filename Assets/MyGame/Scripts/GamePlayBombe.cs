using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayBombe : MonoBehaviour
{
    public GameObject bombeOriginal;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjectBombe", 5, 6);
    }


    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-7, 7);

        return new Vector2(x, 8);

    }

    void SpawnObjectBombe()
    {
        Instantiate(bombeOriginal, GetSpawnPoint(), Quaternion.identity);

    }
}
