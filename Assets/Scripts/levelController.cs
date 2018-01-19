using UnityEngine;
using System.Collections;

public class levelController : MonoBehaviour {
	[SerializeField]
	private GameObject theLevel;
	[SerializeField]
	private GameObject theSphere;
	[SerializeField]
	private Transform spawnPoint;

	void Start(){
		theLevel = gameObject;

	}
	void Update(){
		if (theLevel.transform.Find ("Sphere") == null ) {
			GameObject newSphere =  (GameObject)Instantiate (theSphere, spawnPoint.position, Quaternion.identity);
			newSphere.transform.parent = theLevel.transform;
			newSphere.name = "Sphere";

		} 
	}
}
