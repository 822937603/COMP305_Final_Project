<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> origin/master
﻿// Franco Chong
// File: Life.cs
// Controls the score for the player

using UnityEngine;
<<<<<<< HEAD
=======
=======
﻿using UnityEngine;
>>>>>>> origin/master
>>>>>>> origin/master
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreLabel;
	public int Scorecount = 0;
	
	
	// Use this for initialization
	void Start () {
		
		//calls the setScore method to set the score counter
		this.setScore ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//set the score for the player
	private void setScore(){
		this.scoreLabel.text = "Score: " + this.Scorecount;
	}
	
	//Score will be added
	void OnTriggerEnter(Collider otherObjects){
		if (otherObjects.CompareTag("Gold")) {
			this.Scorecount += 50;
		}
		if (otherObjects.CompareTag ("ArrowShaft")) {
			this.Scorecount +=50;
		}
		if (otherObjects.CompareTag ("Wood")) {
			this.Scorecount +=50;
		}
		this.setScore ();		
	}
}
