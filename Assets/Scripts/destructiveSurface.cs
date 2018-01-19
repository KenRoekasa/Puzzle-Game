using UnityEngine;
using System.Collections;

public class destructiveSurface : MonoBehaviour {
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "pickup") {
			Destroy(collision.gameObject);
		}
	}
}
