using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeknoCamTimer : MonoBehaviour
{
   
    public GameObject cam1;
    public GameObject cam2;
    public float camTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camTime += Time.deltaTime;

        if (camTime < 7)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);


        }
        else if ((camTime > 7) && (camTime < 15))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);

        }
        if (camTime > 19)
        {
            SceneManager.LoadScene("SavunmaB");
        }
    }
}
