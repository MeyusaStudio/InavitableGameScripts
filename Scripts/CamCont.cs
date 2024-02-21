using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCont : MonoBehaviour
{
    private float xRotation = 0.0f;
    public float mouseSensivity = 300.0f;
    public float mouseSensivity2 = 25.0f;
    public GameObject human;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity2;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, 75f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, -90, 90);
        human.transform.Rotate(Vector3.up * mouseX);
    }
}
