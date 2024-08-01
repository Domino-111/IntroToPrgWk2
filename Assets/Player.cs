using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.forward * Input.GetAxisRaw("Vertical");
        movement += Vector3.right * Input.GetAxisRaw("Horizontal");

        rb.AddForce(movement * speed);
    }
}
