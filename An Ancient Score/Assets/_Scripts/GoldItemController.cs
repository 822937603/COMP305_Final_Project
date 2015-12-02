// Jonathan Lee
// File: GoldItemController.cs
// Controls the collection of gold item on the first level
// Sound, collision, and scoring

using UnityEngine;
using System.Collections;

public class GoldItemController : MonoBehaviour {


	// PUBLIC INSTANCE VARIABLES

	public AudioSource goldCollect;


	// Use this for initialization
	void Start () {

		goldCollect = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DestroyGold ()
	{
		Destroy(gameObject, 0.5f);
		goldCollect.Play();
	}

	void onTriggerEnter(Collider otherGameObject)
	{
		Debug.Log ("hello");
		if (otherGameObject.gameObject.tag == "Player" ) {
			Destroy(gameObject);
			}
	}
	//void onCollisionEnter(Collision otherGameObject)
	//{
	//	Debug.Log ("hello");
	//	if (otherGameObject.gameObject.tag == "Player") {
	//		Destroy(gameObject);
	///		
	//	}
	//}
}

