using UnityEngine;

public class GamePlayBombe : MonoBehaviour
{
    public GameObject bombeOriginal;


    void Start()
    {
        InvokeRepeating("SpawnObjectBombe", 6, 7);
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
