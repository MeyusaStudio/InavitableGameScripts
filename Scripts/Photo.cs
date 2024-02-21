using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Photo : MonoBehaviour
{
    public GameObject PZone;
    private bool cKeyPressed = false;
  
    
    
    


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.C))
        {
            cKeyPressed = true;

        }
        else
        {
            cKeyPressed = false;
           
        }
        

    }
       
        
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (cKeyPressed)
            {

                PZone.SetActive(false);

            }
        }

    }

    
}


    

