using UnityEngine;
using System.Collections;

public class destroyCube : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if (other.tag == "pickup") {
			Destroy (other.gameObject);
		}
	}
}
