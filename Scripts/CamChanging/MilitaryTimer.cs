using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MilitaryTimer : MonoBehaviour
{
    
    public float camTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    camTime += Time.deltaTime;
    if ((camTime > 13))
    {
        SceneManager.LoadScene("TestTimer");
    }




    }
}