using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car1CamTimer : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public float camTime;
    public GameObject particle;
    public GameObject carVoice;
    public GameObject fire;

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
            cam5.SetActive(false);

        }
        else if ((camTime > 5) && (camTime < 14))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
        }
        else if ((camTime > 14) && (camTime < 21))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            cam4.SetActive(false);
            cam5.SetActive(false);
        }
        else if ((camTime > 21) && (camTime < 30))
        {
            if ((camTime > 26.50) && (camTime < 29))
            {
                particle.SetActive(true);
            }
            else
            {
                particle.SetActive(false);
            }
            
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(true);
            cam5.SetActive(false);
        }
        else if ((camTime > 30) && (camTime < 40))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(true);
            carVoice.SetActive(false);
            
            if ((camTime > 30) && (camTime < 36))
            {
                fire.SetActive(true);
            }


            if ((camTime > 36))
            {
                SceneManager.LoadScene("Sad");
            }
        }
    }
}
