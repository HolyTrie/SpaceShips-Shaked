﻿using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

/**
 * This component instantiates a given prefab at random time intervals and random bias from its object position.
 */
public class TimedSpawnerRandom : MonoBehaviour
{
    [SerializeField] GameObject[] prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")]
    [SerializeField] float minTimeBetweenSpawns = 0.2f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")]
    [SerializeField] float maxTimeBetweenSpawns = 1.0f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")]
    [SerializeField] float maxXDistance = 1.5f;
    private int initialCount = 0;
    void Start()
    {
        this.StartCoroutine(SpawnRoutine());    // co-routines
    }
    IEnumerator SpawnRoutine()
    {    // co-routines
        while (true)
        {
            float timeBetweenSpawnsInSeconds = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawnsInSeconds);       // co-routines
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x + Random.Range(-maxXDistance, +maxXDistance),
                transform.position.y,
                transform.position.z);
            GameObject newObject = Instantiate(prefabToSpawn[Random.Range(initialCount, prefabToSpawn.Length)], positionOfSpawnedObject, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
        }
    }
}
