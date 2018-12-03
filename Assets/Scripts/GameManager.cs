using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    GameObject gameOverCanvas;

    public static bool gameOver;
    public static GameManager Instance;

	// Use this for initialization
	void Start () {
        Instance = this;
        gameOver = false;

    }


    public void GameOver()
    {
        gameOver = true;
        gameOverCanvas.SetActive(true);
    }
}
