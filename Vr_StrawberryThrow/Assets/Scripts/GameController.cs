using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GameController : MonoBehaviour {


    public static GameController singleton;
    private int score;
    public Text scoreText;

    private void Awake()
    {
        if(singleton == null)
        {
            singleton = this;
        }
    }
    void Start () {
        score = 0;
        UpdateScore();
	}
	
    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

	void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
