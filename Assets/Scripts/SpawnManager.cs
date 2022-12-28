using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    /*
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float spawnPosX = 30;
    private float zRangeUpper = 14.0f;
    private float zRangeLower = 0.0f;
    */
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    
    private float spwanRangeX = 20;
    private float spwanRangeZ = 20;
    private float rightSpawnX = 25;
    private float rightSpawnZS = 15.0f;
    private float rightSpawnZE = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        /*
        int animalIndex1 = Random.Range(0, 3);
        Vector3 spawnPos1 = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex1], spawnPos1, animalPrefabs[animalIndex1].transform.rotation);

        int animalIndex2 = Random.Range(3, 6);
        Vector3 spawnPos2 = new Vector3(-spawnPosX, 0, Random.Range(zRangeLower, zRangeUpper));
        Instantiate(animalPrefabs[animalIndex2], spawnPos2, animalPrefabs[animalIndex2].transform.rotation);

        int animalIndex3 = Random.Range(6, animalPrefabs.Length);
        Vector3 spawnPos3 = new Vector3(spawnPosX, 0, Random.Range(zRangeLower, zRangeUpper));
        Instantiate(animalPrefabs[animalIndex3], spawnPos3, animalPrefabs[animalIndex3].transform.rotation);
        */

        //generate rondom animals at random postions

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spwanRangeX, spwanRangeX), 0, spwanRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        //moving from left to right
        Vector3 spawnPosRight = new Vector3(-rightSpawnX, 0, Random.Range(rightSpawnZS, rightSpawnZE));
        Instantiate(animalPrefabs[animalIndex], spawnPosRight, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 90, 0));

        //again setting the parameters to move animals from right to left
        animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 270, 0);

        Vector3 spawnPosleft = new Vector3(rightSpawnX, 0, Random.Range(rightSpawnZS, rightSpawnZE));
        Instantiate(animalPrefabs[animalIndex], spawnPosleft, animalPrefabs[animalIndex].transform.rotation);
        //Rearranging to old rotation
        animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
