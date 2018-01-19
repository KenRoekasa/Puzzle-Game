using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {
	[SerializeField]
	private wallButton wall_button;
	[SerializeField]
	private GameObject chuteLid;

	void Start(){
		chuteLid = GameObject.Find ("Lid");
	}
	void Update(){
		Debug.Log (chuteLid.transform.rotation);
		if(wall_button.activated){
			openHatch();
		}
	}
	void openHatch(){
		//chuteLid.transform.rotation = Quaternion.Lerp(chuteLid.transform.rotation, work.rotation, Time.deltaTime *2f);

	}
}
