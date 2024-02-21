using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCont : MonoBehaviour
{
    public float moveSpeed;
    public CharacterController characterController;
    public Transform cam;
    public float lookSensivty;
    public float maxXRot;
    public float minXRot;
    private float curXRot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Look();
    }
    void Move()
    {
       
    }
    void Look()
    {
        float x = Input.GetAxis("Mouse X") * lookSensivty;
        float y = Input.GetAxis("Mouse Y") * lookSensivty;

        transform.eulerAngles += Vector3.up * x;
    }
}
