// Jonathan Lee
// File: ArrowItemController.cs
// Controls the collection of arrow item on the first level
// Sound, collision, and scoring

using UnityEngine;
using System.Collections;

public class ArrowItemController : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES

	public AudioSource arrowCollect;


	// Use this for initialization
	void Start () {

		arrowCollect = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider otherGameObject)
	{
		Debug.Log ("hello");
		if (otherGameObject.gameObject.tag == "Player" ) {
			Destroy(gameObject);
		}
	}
}
