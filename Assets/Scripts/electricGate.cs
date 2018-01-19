using UnityEngine;
using System.Collections;

public class electricGate : MonoBehaviour {
	[SerializeField]
	private podiumScript podium_script;
	[SerializeField]
	private GameObject gate;
	private ParticleSystem partSys;
	void Start(){
		partSys = gate.GetComponent<ParticleSystem>();
	}
	void Update () {
		if (podium_script != null) {
			if (podium_script.activated) {
				openGate ();
			}
		}
	}
	void openGate(){
		Destroy (gate.GetComponent<Collider> ());
		partSys.emissionRate = 0;
	}

}
