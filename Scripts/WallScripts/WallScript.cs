using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{     
    public GameObject loseGame;
    public GameObject tryAgain;
    public GameObject planeVoice;
    public GameObject musicVoice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            loseGame.SetActive(true);
            tryAgain.SetActive(true);
            planeVoice.SetActive(false);
            musicVoice.SetActive(false);
            Time.timeScale = 0;
        }
    }


}

