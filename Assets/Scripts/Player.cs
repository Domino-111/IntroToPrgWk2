using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform cameraRig;
    Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movement = cameraRig.forward * Input.GetAxisRaw("Vertical");
        movement += cameraRig.right * Input.GetAxisRaw("Horizontal");

        rb.AddForce(movement * speed);
    }
}
