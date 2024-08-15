using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score;

    public Text scoreText;
    public Text timerText;

    int coinTotal;

    public static GameManager gm;

    float timer;

    public GameObject player;

    void Start()
    {
        gm = this;

        coinTotal = GameObject.FindGameObjectsWithTag("Coin").Length;

        score = 0;
        UpdateScore();

        timer = 0;
    }

    void Update()
    {
        if (score < coinTotal)
        {
            timer += Time.deltaTime;
            timerText.text = "Time: " + Mathf.Round(timer * 10) / 10 + "s";
        }
        
        if (Input.GetKeyDown(KeyCode.R) || player.transform.position.y < -5f)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void UpdateScore()
    {
        scoreText.text = "Coins: " + score + "/" + coinTotal;
    }
}
