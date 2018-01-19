using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {
	[SerializeField]
	private GameObject player;
	private RaycastHit hit;
	private Vector3 dir;
	[SerializeField]
	private ParticleSystem partSys;
	[SerializeField]
	private float dps;
	private playerController player_controller;
	private Rigidbody rb;
	private bool isDead;
	[SerializeField]
	void Start(){
		player = GameObject.Find("Player");
		rb = GetComponent<Rigidbody> ();
	}
	void Update(){
		float rando = Random.Range(0,100);
		dir = player.transform.position - partSys.transform.position;
		Debug.DrawRay (partSys.transform.position, dir,Color.green);
		if (!isDead && rando < 5) {
			if (Physics.Raycast (partSys.transform.position, dir, out hit)) {
				Debug.Log (hit.transform);
				if (hit.transform.tag == "Player") {
					partSys.startSpeed = 20;
					player_controller = hit.transform.GetComponent<playerController> ();
					player_controller.hitpoint -= dps * Time.deltaTime;
				} else {
					partSys.startSpeed = 0;
				}
			}
		} else {
			partSys.startSpeed = 0;
		}
	}
	void FixedUpdate(){
		if (!isDead) {
			partSys.transform.LookAt(player.transform);
			transform.LookAt (player.transform);
		}
	}

	void OnCollisionEnter(Collision collision){
		if (collision.transform.tag == "pickup" && !isDead){
			isDead = true;
			rb.constraints = RigidbodyConstraints.None;
			rb.AddExplosionForce(60,transform.position,5,2f);
			partSys.Stop();
		}
	}
}
