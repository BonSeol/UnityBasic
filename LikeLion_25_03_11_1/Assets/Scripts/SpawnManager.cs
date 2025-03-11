using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy_small;
    public GameObject enemy_normal1;
    public GameObject enemy_normal2;

    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);
        float randomSpawn = Random.Range(0f, 10f);

        if     (randomSpawn <= 1.5f) Instantiate(enemy_normal2, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        else if(randomSpawn <= 4.5f) Instantiate(enemy_normal1, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        else                         Instantiate(enemy_small  , new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
    }

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.5f, 0.4f);
    }

    void Update()
    {
        
    }
}
