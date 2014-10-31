using UnityEngine;
using System.Collections;

public class ZombieBehaviour : MonoBehaviour {

	public float health = 100f;
	public float damageDealt = 10f;
	
	private PlantBehaviour currentTarget;
	private ScoreKeeper myScoreKeeper;
	
	// Use this for initialization
	void Start () {
		this.rigidbody2D.velocity = new Vector2(-1,0);
		myScoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Damage(float amount) {
		//print ("ZombieBehviour damage called");
		health -= amount;
		if(health <= 0f) {
			Destroy(gameObject);
			myScoreKeeper.Add(100);
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		PlantBehaviour plantHit = collision.gameObject.GetComponent<PlantBehaviour>();
		if(plantHit) {
			currentTarget = plantHit;
			InvokeRepeating("Chomp", 1f, 1f);
			print ("Invoke repeat damage");
		}
	}
	
	public void Chomp() {
		if(currentTarget) {
			currentTarget.Damage(damageDealt);
			print ("Chomping Plant");
		} else {
			this.rigidbody2D.velocity = new Vector2(-1, 0);
		}
	}
}
