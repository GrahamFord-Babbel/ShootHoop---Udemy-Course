﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    ScoreKeeper scoreKeeper;
    Text scoreText;

	// Use this for initialization
	void Start () {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + scoreKeeper.score;
	}
}
