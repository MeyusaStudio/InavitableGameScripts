using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SouldierTimer : MonoBehaviour
{
    
    public float camTime;
    // Text Objects

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    camTime += Time.deltaTime;

        if ((camTime > 0) && (camTime < 3))
        {
            text1.SetActive(true);
        }
        if ((camTime > 3) && (camTime < 6))
        {           
            text1.SetActive(false);
            text2.SetActive(true);
        }
        if ((camTime > 6) && (camTime < 10))
        {
            text2.SetActive(false);
            text3.SetActive(true);
        }


        if ((camTime > 10))
        {
            SceneManager.LoadScene("MomInfo");
        }
        
        
        
        



    }
}