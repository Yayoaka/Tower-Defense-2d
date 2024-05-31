using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    public GameObject gameOverUI;
    public GameObject gameWinUI;

    private bool gameEnded = false;

    public int currency;
    public int startMoney = 180;
    public int Lives;
    public int startLives = 5;

    public static int kills;

    private void Awake()
    {
        main = this;
    }

    private void Start()
    {
        Time.timeScale = 1f;
        gameEnded = false;
        currency = startMoney;
        Lives = startLives;
        kills = 0;
    }

    private void Update()
    {
        if (gameEnded) 
        {
            Time.timeScale = 0f;
            return;
        }
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
    }

    public bool SpendCurrrency(int amount) 
    {
        if (amount <= currency)
        {
            currency -= amount;
            return true;
        } else
        {
            return false;
        }
    }

    public void TakeDamage(int amount)
    {
        Lives -= amount;

        if (Lives <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            gameOverUI.SetActive(true);
        }
    }

    public void WinGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            gameWinUI.SetActive(true);
        }
    }
}
