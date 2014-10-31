using UnityEngine;
using System.Collections;

public class TileBehaviour : MonoBehaviour {
	
	private PlayerSpawner playerSpawner;
	
	// Use this for initialization
	void Start () {
		playerSpawner = GameObject.FindObjectOfType(typeof(PlayerSpawner)) as PlayerSpawner;
	}
	
	void OnMouseDown() {
		playerSpawner.SpawnHere(transform.position);
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube(transform.position, new Vector3(2,2,0));
		
		BoxCollider2D tileCollider = gameObject.GetComponent(typeof(BoxCollider2D)) as BoxCollider2D;
		float xSize = tileCollider.size.x * 2;
		float ySize = tileCollider.size.y * 2;
		Gizmos.color = new Color(0f,1f,0f,0.2f);
		Gizmos.DrawWireCube(transform.position, new Vector3(xSize, ySize, 0));
	}
	

}
