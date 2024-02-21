using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CemetaryCam : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public float camTime;

    public GameObject madalyon;
    
    
    

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camTime += Time.deltaTime;

        if (camTime < 10)
        {

            if (camTime > 5)
            {
                madalyon.SetActive(true);
                
            }


            
                
                cam1.SetActive(true);
                cam2.SetActive(false);
            
            


        }
        else if (camTime > 9)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);

            if(camTime > 23)
            {
                panel.SetActive(true);
            }

        }
        
    }
}

