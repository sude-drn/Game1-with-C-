using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    //public int animalIndex;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //hayvanlarý çizgi halinde deðl daðýnýk halde getirme
            SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
       
        Instantiate(AnimalPrefabs[animalIndex], spawnPos, AnimalPrefabs[animalIndex].transform.rotation);
    }
}
