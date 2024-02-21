using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    public AudioClip[] footStepClips;
    public AudioSource audioSource;

    public float footStepTheshold;
    public float footStepRate;
    private float lastFootStepTime;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if(Time.time - lastFootStepTime > footStepRate)
        {
            lastFootStepTime = Time.time;

            audioSource.PlayOneShot(footStepClips[Random.Range(0, footStepClips.Length)]);
        }
    }
}
