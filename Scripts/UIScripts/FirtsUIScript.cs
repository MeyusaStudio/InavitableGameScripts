using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirtsUIScript : MonoBehaviour
{
    public GameObject ayar;
    public void CýkBuradan()
    {
        Application.Quit();
    }

    public void Oyna()
    {
        SceneManager.LoadScene("Info");
    }

    public void Ayarlar()
    {
        ayar.SetActive(true);
    }
    public void MainMenu()
    {
        ayar.SetActive(false);
    }
    

}
