using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[ExecuteInEditMode]
public class RandomOnUnitSphere : MonoBehaviour
{
    /*private void OnEnable()
    {
        transform.Find("Cube").localPosition = Random.onUnitSphere * 5;
    }*/
    
    private void Start()
    {
        // Sets the rigidbody velocity to 10 and in a random direction.
        transform.Find("Cube").localPosition = Random.onUnitSphere * 5;
        transform.Find("Cube").GetComponent<Rigidbody>().velocity = Random.onUnitSphere * 5;
    }
    
}
