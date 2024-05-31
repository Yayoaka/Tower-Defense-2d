using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject ui;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        if (ui != null)
        {
            ui.SetActive(!ui.activeSelf);

            if (ui.activeSelf)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
        else
        {
            Debug.LogError("UI GameObject is not assigned in the inspector.");
        }
    }

    public void ReTry()
    {
        Toggle();
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
