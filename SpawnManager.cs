using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    void Start()
    {
        InvokeRepeating("AnimalRepeating", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AnimalRepeating()
    {
        int xRange = 8;
        float randomIndex = Random.Range(-xRange, xRange);
        int randomAnimal = Random.Range(0, animals.Length);
        Instantiate(animals[randomAnimal], new Vector3(randomIndex, 0, 31), animals[0].transform.rotation);
    }
}
