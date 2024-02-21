using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoctorCamTimer : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public float camTime;

    public GameObject voice1;
    public GameObject voice2;
    public GameObject voice3;
    public GameObject voice4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camTime += Time.deltaTime;

        if (camTime < 3.30)
        {

            cam1.SetActive(true);
            cam2.SetActive(false);
            if (camTime > 0)
            {
                voice1.SetActive(true);
            }
            if (camTime > 2)
            {
                voice2.SetActive(true);
            }


        }
        else if ((camTime > 3.30) && (camTime < 16))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            if ((camTime > 12) && (camTime < 16))
            {
                voice3.SetActive(true);
            }
            
        }
        if (camTime > 19)
        {
            voice4.SetActive(true);
        }
        if (camTime > 30)
        {
            SceneManager.LoadScene("UniTest");
        }
    }
}