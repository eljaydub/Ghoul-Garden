using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSpawner : MonoBehaviour {

	public GameObject plantPrefab;
	public Transform childTo;
	public float minPlantDelay = 6f;
	public Slider timeSlider;
	public float timeTillPlant = 1f;

	// Use this for initialization
	void Start () {
		int indexOfFriendliesLayer = LayerMask.NameToLayer("Friendlies");
		Physics2D.IgnoreLayerCollision(indexOfFriendliesLayer,indexOfFriendliesLayer);
	}
	
	// Update is called once per frame
	void Update () {
		timeTillPlant -= Time.deltaTime;
		timeSlider.value = timeTillPlant / minPlantDelay;
	}
	
	public void SpawnHere(Vector3 position) {
	
		if(timeTillPlant <= 0f) {
			Vector3 offset = new Vector3(0f,0f,-1f);
			GameObject myPlant = Instantiate(plantPrefab, position+offset, Quaternion.identity) as GameObject;
			myPlant.transform.parent = childTo;
			timeTillPlant = minPlantDelay;
		}
	}
}
