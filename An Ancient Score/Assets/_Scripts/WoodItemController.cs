// Jonathan Lee
// File: WoodItemController.cs
// Controls the collection of wood item on the first level
// Sound, collision, and scoring

using UnityEngine;
using System.Collections;

public class WoodItemController : MonoBehaviour {


	// PUBLIC INSTANCE VARIABLES
	
	private AudioSource woodCollect;


	// Use this for initialization
	void Start () {
	
		woodCollect = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			woodCollect.Play();
			Destroy(gameObject,0.5f);
		}
	}
}
