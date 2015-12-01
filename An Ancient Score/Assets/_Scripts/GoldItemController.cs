// Jonathan Lee
// File: GoldItemController.cs
// Controls the collection of gold item on the first level
// Sound, collision, and scoring

using UnityEngine;
using System.Collections;

public class GoldItemController : MonoBehaviour {


	// PUBLIC INSTANCE VARIABLES

	public AudioSource goldCollect;
	public GameObject gold;

	// Use this for initialization
	void Start () {

		goldCollect = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DestroyGold ()
	{
		Destroy (gameObject);
	}

	void onTriggerEnter(Collider otherGameObject)
	{
		if (otherGameObject.tag == "Player") {
			Debug.Log("col");
			goldCollect.Play();
			Invoke("DestroyGold", 0.5f);
		}
	}
}

