using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
    public Animator animator;
    public GameObject fatih;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (Input.GetKey(KeyCode.E))
            {
                animator.SetBool("IsClimb", true);
                fatih.transform.Translate(new Vector3(0f, 2f, 0f) * Time.deltaTime);
                
            }
            else
            {
                animator.SetBool("IsClimb", false);
            }
            

            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                animator.SetBool("IsClimb", false);

            }
            



        }
    }
}
