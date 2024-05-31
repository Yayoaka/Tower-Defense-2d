using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class EnemySpawner : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private GameObject[] enemyPrefabs;

    [Header("Attribute")]
    [SerializeField] private int baseEnemies = 6;
    [SerializeField] private float enemiePerSecond = 1f;
    [SerializeField] private float timeBetweenWaves = 5f;
    [SerializeField] private float difficultyScalingFactor = 0.9f;
    [SerializeField] private float enemiesPerSecondCap = 15f;
    [SerializeField] private float hpScale = 1.1f;

    [Header("Events")]
    public static UnityEvent onEnemyDestroy = new UnityEvent();

    public static int currentWave = 1;

    private float timeSinceLastSpawn;
    private int enemiesAlive;
    private int enemiesLeftToSpawn;
    private float eps;
    private bool isSpawning = false;

    private void Awake()
    {
        onEnemyDestroy.AddListener(EnemyDestroy);
    }

    private void Start()
    {
        StartCoroutine(StartWave());
    }

    private void Update()
    {
        if (!isSpawning) return;

        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= (1f / eps) && enemiesLeftToSpawn > 0)
        {
            SpawnEnemy();
            enemiesLeftToSpawn--;
            enemiesAlive++;
            timeSinceLastSpawn = 0f;
        }

        if (enemiesAlive == 0 && enemiesLeftToSpawn == 0)
        {
            EndWave();
        }
    }

    private void EnemyDestroy()
    {
        LevelManager.kills++;
        enemiesAlive--;
    }

    private IEnumerator StartWave()
    {
        yield return new WaitForSeconds(timeBetweenWaves);

        isSpawning = true;
        enemiesLeftToSpawn = EnemiesPerWave();
        eps = EnemiesPerSecond();
    }

    private void EndWave()
    {
        isSpawning = false;
        currentWave++;

        if (currentWave > 20)
        {
            LevelManager.main.WinGame();
        }
        StartCoroutine(StartWave());
    }

    private void SpawnEnemy()
    {
        int index = UnityEngine.Random.Range(0, enemyPrefabs.Length);
        GameObject prefabToSpawn = enemyPrefabs[index];
        GameObject enemyObject = Instantiate(prefabToSpawn, LevelManager.main.startPoint.position, Quaternion.identity);

        Health enemyHealth = enemyObject.GetComponent<Health>();
        if (enemyHealth != null)
        {
            enemyHealth.hitPoints = Mathf.RoundToInt(enemyHealth.hitPoints * Mathf.Pow(hpScale, currentWave - 1));
        }
    }


    private int EnemiesPerWave()
        {
            return Mathf.RoundToInt(baseEnemies * Mathf.Pow(currentWave, difficultyScalingFactor));
        }

    private float EnemiesPerSecond()
    {
        return Mathf.Clamp(enemiePerSecond * Mathf.Pow(currentWave, difficultyScalingFactor), 0, enemiesPerSecondCap);
    }
}
