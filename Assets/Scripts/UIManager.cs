using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreTextDisplay;

    //private GameManager gameManager;

    [SerializeField]
    private GameObject titleGO;

    private void Start()
    {
        //gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void UpdateScore(int score)
    {
        scoreTextDisplay.text = score.ToString();
    }
    public void ShowTitleScreen(bool isShown)
    {
        titleGO.SetActive(isShown);
    }
}
