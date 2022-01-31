using UnityEngine;

public class GameplayCandy : MonoBehaviour
{
    public GameObject candyOriginal;
    public GameObject player;

    void Start()
    {
        InvokeRepeating("SpawnObjectCandy", 2, 2);
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