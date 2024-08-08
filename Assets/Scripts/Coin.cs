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
        GameManager.score += 100;
        Debug.Log(GameManager.score);
        Destroy(gameObject);
    }
}
