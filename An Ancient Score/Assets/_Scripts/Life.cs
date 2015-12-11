// Franco Chong
// File: Life.cs
// Controls the life of the player

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Life : MonoBehaviour {

	public Text lifeLabel;
	public int lifecount = 5;
	
	
	// Use this for initialization
	void Start () {
		
		//calls the setLife method to set the life counter
		this.setLife ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//set the number of life available for the player.
	private void setLife(){
		this.lifeLabel.text = "Life: " + this.lifecount;
	}
	
	//Life will be deducted upon sensing a collision.
	void OnTriggerEnter(Collider otherObjects){
		if (otherObjects.tag == "Enemy") {
			this.lifecount -= 1;
		}
		//Restarts the level when the player loses all their life.
		if(this.lifecount <=0){
			Application.LoadLevel(Application.loadedLevel);
			
		}
		this.setLife ();		
	}
}
