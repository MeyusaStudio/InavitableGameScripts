using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 15f, 10f) * Time.deltaTime);

        }
        else
        {
            transform.Translate(new Vector3(0, -10f, 0f) * Time.deltaTime);
        }
       
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0f, 30f) * Time.deltaTime);

        }
        else
        {
            transform.Translate(new Vector3(0, -10f, 0f) * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f, 0f, 0f) * Time.deltaTime);
            transform.Rotate(new Vector3(0f, 16f, 0f) * Time.deltaTime);
            

        }
        
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f, 0f, 0f) * Time.deltaTime);
            transform.Rotate(new Vector3(0f, -16f, 0f) * Time.deltaTime);

        }


    }

    
}
