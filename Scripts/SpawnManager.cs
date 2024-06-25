using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawn;
    private float spawnRange =9;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(3);
    }
    void SpawnEnemyWave(int enemiestoSpawn)
    {
        for(int i = 0;i<enemiestoSpawn;i++)
        {
            Instantiate(spawn, GenerateSpawnPosition(), spawn.transform.rotation);
        }

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 RandomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return RandomPos;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
