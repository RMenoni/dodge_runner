using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public List<Transform> spawnPoints;
    public GameObject blockPrefab;
    private float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;

    void Start()
    {
        timeToSpawn = Time.time + timeToSpawn;
    }

    void Update () {
        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
	}

    void SpawnBlocks ()
    {
        int randomIndex = Random.Range(0, spawnPoints.Count);
        for(int i = 0; i < spawnPoints.Count; ++i)
        {
            if(randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
