using UnityEngine;
using System.Collections;

public class Lose : MonoBehaviour {

	public LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D coll) {
		levelManager.LoadLevel("Win Screen");
	}
}
