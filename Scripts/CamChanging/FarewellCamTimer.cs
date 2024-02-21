using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarewellCamTimer : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    
    public float camTime;

    // Text Objects

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;


    // Update is called once per frame
    void Update()
    {
        camTime += Time.deltaTime;

        if (camTime < 3)
        {
            text1.SetActive(true);
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            
        }
        else if ((camTime > 3) && (camTime < 6))
        {
            text1.SetActive(false);
            text2.SetActive(true);
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            
        }
        else if ((camTime > 6) && (camTime < 12))
        {
            if ((camTime > 8) && (camTime < 12))
            {
                text2.SetActive(false);
                text3.SetActive(true);
            }
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            
        }
        else if ((camTime > 12) && (camTime < 22))
        {
            if ((camTime > 12) && (camTime < 14))
            {
                text3.SetActive(false);
                text4.SetActive(true);
            }
            if ((camTime > 19) && (camTime < 23))
            {
                text4.SetActive(false);
                text5.SetActive(true);
            }
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            
        }
        else if (camTime > 23)
        {
            SceneManager.LoadScene("PlaneInfo");
        }
        
    }
}
