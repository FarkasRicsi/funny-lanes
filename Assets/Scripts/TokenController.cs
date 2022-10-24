using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class TokenController : MonoBehaviour
{
    [SerializeField]
    public GameObject circlePrefab;

    [SerializeField]
    public ScriptableToken[] tokens;

    [SerializeField]
    public GameObject[] spawnPoints;

    [SerializeField]
    private GameManager gameManager;

    private Coroutine spawnCircleTokenCoroutine;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //CreatePrefab();
        //StartSpawnRoutines();
    }

    public virtual void CreatePrefab()
    {
    }

    public void StartSpawnRoutines()
    {
        spawnCircleTokenCoroutine = StartCoroutine(SpawnCircleTokenCoroutine());
    }
    public void StopSpawnRoutines()
    {
        StopCoroutine(spawnCircleTokenCoroutine);
    }


    private IEnumerator SpawnCircleTokenCoroutine()
    {
        Random r = new Random();
        int tokenID;
        while (gameManager.GameIsRunning)
        {
            tokenID = r.Next(0, tokens.Length);
            InstantiateCircle(tokens[tokenID].color, tokens[tokenID].colorRGB, r.Next(0, spawnPoints.Length));
            float wait = r.Next(45, 100) / 100.0f;
            yield return new WaitForSeconds(wait);
        }
    }

    private void InstantiateCircle(EColor color, Color colorRGB, int spawnPoint)
    {
        CircleTokenBehaviour circle = circlePrefab.GetComponent<CircleTokenBehaviour>();
        circle.color = color;
        circle.spriteRenderer.color = colorRGB;
        Instantiate(circlePrefab, spawnPoints[spawnPoint].transform.position, Quaternion.identity);
    }

}
