using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SadCamTimer : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public float camTime;
    // Text Objects

    public GameObject text1;
    public GameObject text2;

    public GameObject voice1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camTime += Time.deltaTime;

        if (camTime < 9)
        {
            if ((camTime > 1) && (camTime < 3))
            {
                text1.SetActive(true);
            }
            cam1.SetActive(true);
            cam2.SetActive(false);
            
            if ((camTime > 3))
            {
                text1.SetActive(false);
                text2.SetActive(true);
            }



        }
        else if ((camTime > 9) && (camTime < 21))
        {
            cam2.SetActive(true);
            if ((camTime > 10))
            {
                voice1.SetActive(true);
                text2.SetActive(false);
            }


            if ((camTime > 20))
            {
                SceneManager.LoadScene("CeremonyInfo");
            }

        }

    }
}
