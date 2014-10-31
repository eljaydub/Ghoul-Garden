using UnityEngine;
using System.Collections;

public class SphereGizmo : MonoBehaviour {

	public float explosionRadius;

	void OnDrawGizmos() {
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(transform.position, explosionRadius);
	}
	
	void onDrawGizmoSelected() {
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, explosionRadius);
	}
}
