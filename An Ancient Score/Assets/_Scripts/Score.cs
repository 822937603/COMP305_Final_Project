<<<<<<< HEAD
=======

// Franco Chong
>>>>>>> origin/master
// File: Score.cs
// Controls the score for the player

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreLabel;
	public int Scorecount = 0;
<<<<<<< HEAD
=======

>>>>>>> origin/master
	public GameObject portal;
	
	// Use this for initialization
	void Start () {

		portal.gameObject.SetActive (false);
		//calls the setScore method to set the score counter
		this.setScore ();
<<<<<<< HEAD
		
	}
=======
	}


	
	
	// Use this for initialization
	//void Start () {
		
		//calls the setScore method to set the score counter
	//	this.setScore ();
		

	//}

	//}

>>>>>>> origin/master
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//set the score for the player
	private void setScore(){
		this.scoreLabel.text = "Score: " + this.Scorecount;
	}

<<<<<<< HEAD
=======

>>>>>>> origin/master
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
<<<<<<< HEAD
=======

>>>>>>> origin/master
		if (this.Scorecount >= 250) {
			portal.gameObject.SetActive (true);
			if (otherObjects.CompareTag ("PortalCollider")) {
				Application.LoadLevel ("Menu");
			}
		}
<<<<<<< HEAD
=======

>>>>>>> origin/master
		this.setScore ();		
	}
}
