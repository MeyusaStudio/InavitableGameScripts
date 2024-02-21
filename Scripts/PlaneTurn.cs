using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTurn : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {

            animator.SetBool("IsRight", true);
        }
        else
        {
            animator.SetBool("IsRight", false);
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsLeft", true);

        }
        else
        {
            animator.SetBool("IsLeft", false);
        }
    }
}
