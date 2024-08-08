using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrack : MonoBehaviour
{
    public GameObject track;
    public float camSpeed;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        transform.position = track.transform.position;
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * camSpeed);
    }
}
