using UnityEngine;
using System.Collections;

public class PeaBehaviour : MonoBehaviour {

	public float damageDealt = 10f;

	void OnCollisionEnter2D(Collision2D collision) {
		ZombieBehaviour zombieHit = collision.gameObject.GetComponent<ZombieBehaviour>();
		if (zombieHit) {
			zombieHit.Damage(damageDealt);
			Destroy(gameObject);
		}
		
	}
}
