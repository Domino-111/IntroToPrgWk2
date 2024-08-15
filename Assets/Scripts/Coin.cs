using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 180);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameManager.score++;
        Debug.Log(GameManager.score);
        GameManager.gm.UpdateScore();
        Destroy(gameObject);
    }
}
