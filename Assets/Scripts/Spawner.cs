using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Car;
    public GameObject Car2;
    public float SpawnDelay = .4f;
    float SpawnCarTime = 0f;
    public Transform[] SpawnPoints;
    float Countdown = 3f;

    void Start()
    {
        if(Countdown <= 0f)
        {
            SpawnCar();
            Countdown = 3f;

        }
        else 
        {
            // The -= I did not know about until I wanted to do it faster so I looked it up 
            // https://forum.unity.com/threads/how-to-increment-decrement-a-variable-by-a-decimal-number.99076/
            Countdown -= Time.deltaTime;
        }
    }

    
    void Update()
    {
        // Spawn car after a certain amount of time
        if (SpawnCarTime <= Time.time)
        {
            SpawnCar();
            SpawnCarTime = Time.time + SpawnDelay;
        }
        
    }


    void SpawnCar()
    {
        // Random car generator for spawns
        int RandomCar = Random.Range(0, SpawnPoints.Length);
        Transform SpawnPoint = SpawnPoints[RandomCar];

        // To choose which car that will spawn so its more random.
        int i = Random.Range(1, 6);
        GameObject ChosenCar;
        if (i > 3)
        {
            ChosenCar = Car;
        }
        else
        {
            ChosenCar = Car2;
        }


        Instantiate(ChosenCar, SpawnPoint.position, SpawnPoint.rotation);
        
    }    
}
