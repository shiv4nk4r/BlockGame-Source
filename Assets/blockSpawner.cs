using UnityEngine;

public class blockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject block;

    private float timeToSpawn = 2f;
    public float spawnRate = 1f;

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            spawnBlocks();
            timeToSpawn = Time.time + spawnRate;
        }
        
    }

    void spawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i != randomIndex)
            {
                Instantiate(block, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
