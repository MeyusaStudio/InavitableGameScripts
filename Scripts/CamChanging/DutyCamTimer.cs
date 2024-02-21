using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DutyCamTimer : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public float camTime;

    // Text Objects

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;

    // Sound objects

    public GameObject voice1;
    public GameObject voice2;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camTime += Time.deltaTime;

        if (camTime < 5)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);

        }
        else if ((camTime > 5) && (camTime < 9))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            cam4.SetActive(false);
            if ((camTime > 7) && (camTime < 8))
            {
                voice2.SetActive(true);
            }
        }
        else if ((camTime > 9) && (camTime < 29))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            cam4.SetActive(false);
            if ((camTime > 14) && (camTime < 15))
            {
                voice1.SetActive(false);
            }
            if ((camTime > 19) && (camTime < 28))
            {
                text1.SetActive(true);
            }
        }
        else if ((camTime > 29) && (camTime < 50))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(true);
            text1.SetActive(false);
            if ((camTime > 31) && (camTime < 42))
            {
                text2.SetActive(true);
            }
            if ((camTime > 46) && (camTime < 50))
            {
                text2.SetActive(false);

                if ((camTime > 49) && (camTime < 50))
                {
                    text3.SetActive(true);
                }
                

            }


        }
        else if ((camTime > 50) && (camTime < 60))
        {
            if(camTime > 52)
            {
                text3.SetActive(false);
            }
            if (camTime > 52)
            {
                text4.SetActive(true);
            }

            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            cam4.SetActive(false);
            
            
            if ((camTime > 54) && (camTime < 58))
            {
                SceneManager.LoadScene("Farewell");
            }


        }
    }
}
