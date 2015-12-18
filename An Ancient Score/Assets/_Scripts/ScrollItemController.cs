// Jonathan Lee
// File: ScrollItemController.cs
// Controls the collection of scroll item on the second level
// Sound, collision, and scoring

using UnityEngine;
using System.Collections;

public class ScrollItemController : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES
	public AudioSource scrollCollect;


	// Use this for initialization
	void Start () {
		scrollCollect = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			scrollCollect.Play();
			Destroy(gameObject,0.5f);
		}
	}
}


