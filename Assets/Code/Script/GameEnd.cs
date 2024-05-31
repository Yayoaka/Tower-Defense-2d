using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public Text killText;

    void OnEnable()
    {
        killText.text = LevelManager.kills.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
        EnemySpawner.currentWave = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        EnemySpawner.currentWave = 1;

    }
}
