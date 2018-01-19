using UnityEngine;
using System.Collections;

public class buttonScript : MonoBehaviour {
	public bool activated = false;
	private Renderer rend;
	
	void Start(){
		rend = GetComponent<Renderer> ();
	}
	
	void OnCollisionEnter(Collision collision){
		if (activated == false) {
			if(collision.gameObject.tag == "pickup") {
				activated = true;
			}
		}
	}
	void Update(){
		if (activated) {
			rend.material.color = Color.green;
			
		}
	}
}

