using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject PipeSetPrefab;
    public float pipeSpawnTime;
    public Transform spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipeSet", 0, pipeSpawnTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipeSet ()
    {
        Instantiate(PipeSetPrefab, spawnPosition.position, Quaternion.identity);

    }
}
