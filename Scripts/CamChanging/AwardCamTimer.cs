using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AwardCamTimer : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public float camTime;
    public GameObject voice1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camTime += Time.deltaTime;

        if (camTime < 4)
        {
            voice1.SetActive(true);
            cam1.SetActive(true);
            cam2.SetActive(false);


        }
        else if ((camTime > 4) && (camTime < 12))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);

        }
        if (camTime > 12)
        {
            SceneManager.LoadScene("Cemetery");
        }
    }
}
