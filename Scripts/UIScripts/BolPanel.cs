using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BolPanel : MonoBehaviour
{

    public GameObject panel1;
    public GameObject panel2;
    public void Hangar()
    {
        SceneManager.LoadScene("Hangaar");

    }

    public void PNL1()
    {
        panel1.SetActive(true);
    }

    public void PNL2()
    {
        panel2.SetActive(true);
    }
}
