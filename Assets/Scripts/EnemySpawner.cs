using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	
	public GameObject enemyPrefab;
	public Transform childTo;
	
	[Range (0.95f, 1.0f)] public float threshold = 0.9981f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float value = Random.Range(0f, 1f);
		
		if(value > threshold) {
			GameObject myEnemy = Instantiate(enemyPrefab) as GameObject;
			myEnemy.transform.parent = childTo;
			myEnemy.transform.position = transform.position;
		}
	}
}
