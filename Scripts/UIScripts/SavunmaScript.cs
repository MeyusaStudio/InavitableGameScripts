using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SavunmaScript : MonoBehaviour
{
    public GameObject savunmaPanel;

    public void Savunma()
    {
        savunmaPanel.SetActive(true);
    }
    public void Mission()
    {
        SceneManager.LoadScene("Mission");
    }

}
