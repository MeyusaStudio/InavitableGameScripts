using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ActiveZone : MonoBehaviour
{
    public GameObject PZone1;   
    public GameObject PZone2;
    public GameObject PZone3;
    public GameObject PZone4;
    public GameObject PZone5;
    bool z1 = true;
    bool z2 = true;
    bool z3 = true;
    bool z4 = true;
    bool z5 = true;
    public float isaretSayi = 0;

    public Text isaret;

    public GameObject loseGame;
    public GameObject winGame;
    public GameObject planeVoice;
    public GameObject musicVoice;
    
    

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (!PZone1.activeInHierarchy && z1)
        {
            isaretSayi = isaretSayi + 1;
            isaret.text = isaretSayi.ToString() + " / 5";
            z1 = false;
        }       
       
        if (!PZone2.activeInHierarchy && z2)
        {
            isaretSayi = isaretSayi + 1;
            isaret.text = isaretSayi.ToString() + " / 5";
            z2 = false;
        }
       
        if (!PZone3.activeInHierarchy && z3)
        {
            isaretSayi = isaretSayi + 1;
            isaret.text = isaretSayi.ToString() + " / 5";
            z3 = false;
        }
       
        if (!PZone4.activeInHierarchy && z4)
        {
            isaretSayi = isaretSayi + 1;
            isaret.text = isaretSayi.ToString() + " / 5";
            z4 = false;
        }
       
        if (!PZone5.activeInHierarchy && z5)
        {
            isaretSayi = isaretSayi + 1;
            isaret.text = isaretSayi.ToString() + " / 5";
            z5 = false;
        }

        if(isaretSayi== 5)
        {
            winGame.SetActive(true);
            planeVoice.SetActive(false);
            musicVoice.SetActive(false);
            
            
            Time.timeScale = 0;
        }
    }
}
