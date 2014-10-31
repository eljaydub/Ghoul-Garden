using UnityEngine;
using System.Collections;

public class PlantBehaviour : MonoBehaviour {

	public float timeBetweenShots = 1.5f;
	public GameObject peaPrefab;
	public float projectileSpeed = 10.0f;
	public float health = 100f;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("Shoot", 1.0f, timeBetweenShots);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Shoot() {
		print ("Shoot called for plant at: "+transform.position);
		GameObject pea = Instantiate(peaPrefab, transform.position, Quaternion.identity) as GameObject;
		pea.transform.parent = transform;
		pea.rigidbody2D.velocity = new Vector3(projectileSpeed, 0, 0);
	}
	
	public void Damage(float amount) {
		health -= amount;
		if(health <= 0f) {
			Destroy(gameObject);
		}
	}
}
