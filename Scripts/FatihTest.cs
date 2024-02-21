using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatihTest : MonoBehaviour
{
    private Animator animator;
    
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
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            
            animator.SetBool("IsWalk",true);
            
            
        }
        else
        {
            animator.SetBool("IsWalk", false);
        }

       
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("IsRun", true);
            
        }
        else
        {
            animator.SetBool("IsRun", false);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
         
            animator.SetBool("IsProne", true);
            
        }
        else
        {
            animator.SetBool("IsProne", false);
        }

        if (Input.GetButton("Jump"))
        {
            animator.SetBool("IsJump", true);
            
        }
        else
        {
            animator.SetBool("IsJump", false);
        }
        
        
        

    }
}
