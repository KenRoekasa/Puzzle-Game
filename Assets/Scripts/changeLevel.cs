using UnityEngine;
using System.Collections;

public class changeLevel : MonoBehaviour {
	[SerializeField]
	private GameObject theLevel;

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player"){
			other.GetComponent<playerController>().currentLevel = theLevel;
		}
	}
}
