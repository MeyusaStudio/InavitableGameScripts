using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    
    public GameObject zone;
    public ParticleSystem particle;
    private bool eKeyPressed = false;
    public GameObject explosion;
    

  
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            eKeyPressed = true;
        }
        else
        {
            eKeyPressed = false;
        }
        
        


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (eKeyPressed)
            {
                particle.Play();
                explosion.SetActive(true);
                zone.SetActive(false);
            }
            else
            {
                explosion.SetActive(false);
            }


        }

    }
    

    
}
