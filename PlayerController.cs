using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horInput;
    public float moveHorSpeed = 30;
    public float xRange = 8;
    public GameObject fireFood;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * moveHorSpeed * horInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -8) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fireFood, transform.position, fireFood.transform.rotation);
        }
    }
}
