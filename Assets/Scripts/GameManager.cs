using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool gameIsRunnuing;
    public bool GameIsRunning
    {
        get { return gameIsRunnuing; }
        set
        {
            gameIsRunnuing = value;
            if (!gameIsRunnuing)
            {
                StopTheGame();
            }
        }
    }

    private int _score;
    public int score
    {
        get { return _score; }
        set
        {
            _score = value;
            uiManager.UpdateScore(_score);
        }
    }

    [SerializeField]
    private UIManager uiManager;

    [SerializeField]
    private TokenController tokenController;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void StartTheGame()
    {
        gameIsRunnuing = true;
        uiManager.GetComponent<UIManager>().ShowTitleScreen(false);
        uiManager.GetComponent<UIManager>().UpdateScore(0);

        tokenController.StartSpawnRoutines();
    }
    public void StopTheGame()
    {
        _score = 0;
        uiManager.GetComponent<UIManager>().ShowTitleScreen(true);

        GameObject[] tokens = GameObject.FindGameObjectsWithTag("Token");
        foreach (var item in tokens)
        {
            Destroy(item);
        }

    }
}
