using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject panel1;
    public GameObject panel2;

    public GameObject button1;
    public GameObject button2;

    bool winn = false;



    void Update()
    {
        if (remainingTime > 0)
        {
            if (!winn)
            {
                remainingTime -= Time.deltaTime;
            }
            
            
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            cam1.SetActive(false);
            cam2.SetActive(true);
            panel2.SetActive(true);
            button2.SetActive(true);
            Time.timeScale = 0;



        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (remainingTime > 0)
        {
            winn = true;
            Time.timeScale = 0;
            cam1.SetActive(false);
            cam2.SetActive(true);
            panel1.SetActive(true);
            button1.SetActive(true);
        }
    }
}
