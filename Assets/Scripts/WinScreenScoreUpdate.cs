using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinScreenScoreUpdate : MonoBehaviour {

	private ScoreKeeper scoreKeeper;
	private Text scoreText; 

	// Use this for initialization
	void Start () {
		scoreText = this.GetComponent<Text>();
		scoreKeeper = GameObject.FindObjectOfType(typeof(ScoreKeeper)) as ScoreKeeper;
		if(scoreText & scoreKeeper) {
			scoreText.text = "Your Score: " + scoreKeeper.GetScore().ToString();
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
