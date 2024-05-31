using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        EnemySpawner.currentWave = 1;
    }

    public void ReTry()
    {
        SceneManager.LoadScene(1);
        EnemySpawner.currentWave = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        EnemySpawner.currentWave = 1;
    }

    public void HandleExitGame()
    {
        Application.Quit();
    }
}
