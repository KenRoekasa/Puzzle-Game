using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	public float hitpoint;
	private float horizontal;
	private float vertical;
	[SerializeField]
	private float movement_speed;
	private Vector3 movement;
	[SerializeField]
	public GameObject currentLevel;
	void Start(){
		hitpoint = 100;
	}
	void Update(){
		Debug.Log (hitpoint);
		if (hitpoint < 0) {
			Time.timeScale = 0;
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		horizontal = Input.GetAxis("Horizontal");
		vertical = Input.GetAxis("Vertical");
		movement = new Vector3(horizontal,0,vertical);
		transform.Translate(movement * movement_speed * Time.deltaTime);
	}
}
