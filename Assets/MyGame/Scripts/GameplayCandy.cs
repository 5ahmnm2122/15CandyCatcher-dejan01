using UnityEngine;

public class GameplayCandy : MonoBehaviour
{
    public GameObject candyOriginal;


    void Start()
    {
        InvokeRepeating("SpawnObjectCandy", 3, 4);
    }


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