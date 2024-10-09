using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballScript : MonoBehaviour
{   
    Rigidbody rb;
    internal void throwSnowball(Transform thrower)
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
            print("Found Rigid Body");
        else
            print("Could not find Rigid Body");

        rb.AddExplosionForce(500, thrower.position, 3);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
