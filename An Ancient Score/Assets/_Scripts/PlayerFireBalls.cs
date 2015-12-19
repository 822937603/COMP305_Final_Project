using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

public class PlayerFireBalls: MonoBehaviour {
	
	// PUBLIC INSTANCE VARIABLES - ACCESSIBLE ON INSPECTOR
	public GameObject impact;
	public AudioSource crossbowFireSound;
	
	// PRIVATE INSTANCE VARIABLES
	private GameObject[] _impacts;
	private int _currentImpact = 0;
	private int _maxImpacts = 2;
	
	private bool _shooting = false;
	private Transform _transform;
	
	
	
	// Use this for initialization
	void Start () {
		this._impacts = new GameObject[this._maxImpacts];
		for (int impactCount = 0; impactCount < this._maxImpacts; impactCount++) {
			this._impacts[impactCount] = (GameObject)Instantiate(this.impact);
		}
		
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown ("Fire1")) {
			this.crossbowFireSound.Play();
			this._shooting = true;
		}
		if (CrossPlatformInputManager.GetButtonUp ("Fire1")) {
			this._shooting = false;
		}
		
	}
	
	// physics update
	void FixedUpdate() {
		
		if (this._shooting){
			this._shooting = false;
			
			RaycastHit hit;
			
			if(Physics.Raycast(this._transform.position, this._transform.forward, out hit, 50f)){
				
				if(hit.transform.CompareTag("Enemy")){
					//destroy barrel object upon hit
					Destroy (hit.transform.gameObject);
					//this.gamecontroller.Score += 100;
				}
				
				this._impacts[this._currentImpact].transform.position = hit.point;
				
				if(++this._currentImpact >= this._maxImpacts){
					this._currentImpact =0;
				}
			}
		}
	}
}
















