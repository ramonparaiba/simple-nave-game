using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnElements : MonoBehaviour
{
   public GameObject enemyPrefab; // Prefab da nave inimiga
    public GameObject powerUpPrefab; // Prefab do power-up

    public float spawnRangeX = 7.5f; // Alcance de spawn em X
    public float spawnPosY = 5f; // Posição Y de spawn

    private float spawnIntervalEnemy = 2f; // Intervalo de spawn para inimigos
    private float spawnIntervalPowerUp = 10f; // Intervalo de spawn para power-ups

    void Start()
    {
        // Inicia o spawn de inimigos e power-ups
        InvokeRepeating("SpawnEnemy", 2.0f, spawnIntervalEnemy);
        InvokeRepeating("SpawnPowerUp", 10.0f, spawnIntervalPowerUp);
    }

    void SpawnEnemy()
    {
        // Gera uma posição aleatória de spawn
        Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY);
        // Instancia a nave inimiga
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }

    void SpawnPowerUp()
    {
        // Gera uma posição aleatória de spawn
        Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY);
        // Instancia o power-up
        Instantiate(powerUpPrefab, spawnPos, Quaternion.identity);
    }
}
