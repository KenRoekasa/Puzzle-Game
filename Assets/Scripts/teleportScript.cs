using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportScript : MonoBehaviour {
	[SerializeField]
	private Transform telePosition;
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player"){
			other.transform.position = telePosition.position;
		}
	}
}
