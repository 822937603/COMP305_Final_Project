using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {



	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider otherGameObject)
	{
		Debug.Log ("hello");
		if (otherGameObject.gameObject.tag == "Gold") {
			Destroy (otherGameObject);
			
		}
	}
}
