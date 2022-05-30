using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    private float timer;
    public float ReSpawnTime = 5f;
    public float TimeInterval;
    public GameObject[] Car;
    public int CarNum;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;

        if (timer >= ReSpawnTime)
        {
            Spawn();
            
            ReSpawnTime += TimeInterval;
        }
    }

    void Spawn()
    {
        CarNum = Random.Range(0, Car.Length);
        Instantiate(Car[CarNum], transform.position, transform.rotation);
    }
}
