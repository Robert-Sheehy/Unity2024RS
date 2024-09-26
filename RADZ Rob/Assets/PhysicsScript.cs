using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
            print("Found Rigid Body");
        else
            print("Could not find Rigid Body");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddExplosionForce(5000, 
                transform.position + new Vector3(0,-1,-1),  2);
        
    }
}
