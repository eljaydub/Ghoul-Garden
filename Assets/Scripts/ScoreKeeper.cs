using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

	public Text scoreText;
	
	private int score = 0;
	
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
		scoreText.text = score.ToString();
		
	}
	
	public void Add(int amount) {
		score += amount;
		scoreText.text = score.ToString();
	}
	
	public int GetScore() {
		return score;
	}
}
