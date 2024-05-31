using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuRight : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI livesUI;
    [SerializeField] TextMeshProUGUI killsUI;
    [SerializeField] TextMeshProUGUI waveUI;

    private void OnGUI()
    {
        livesUI.text = LevelManager.main.Lives.ToString();

        killsUI.text = LevelManager.kills.ToString();

        waveUI.text = EnemySpawner.currentWave.ToString() + " / 20";
    }
}
