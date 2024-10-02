using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHero : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
            print("Could not find Animator Component");
        else
            print("Animator Component found");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            animator.SetBool("isRunning", true);
        }

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, 30*Time.deltaTime);
    }
}
