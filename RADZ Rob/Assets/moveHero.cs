using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHero : MonoBehaviour
{
    public GameObject snowBallCloneTemplate;
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
        animator.SetBool("isRunning", false);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject newSnowballGO = Instantiate(snowBallCloneTemplate , transform.position + transform.forward + Vector3.up, Quaternion.identity);
            SnowballScript myNewSnowball = newSnowballGO.GetComponent<SnowballScript>();
            myNewSnowball.throwSnowball(transform);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            animator.SetBool("isRunning", true);
        }

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, 30*Time.deltaTime);
    }



    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);


      
        footballScript myFootball = collision.gameObject.GetComponent<footballScript>();
        if (myFootball != null)
        {
            myFootball.Kick();
        }

    }
}
