using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GameController : MonoBehaviour {

    private int score;
    public Text scoreText;


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
