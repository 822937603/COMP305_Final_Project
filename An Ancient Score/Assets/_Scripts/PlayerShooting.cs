using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

public class PlayerShooting : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES - ACCESSIBLE ON INSPECTOR
	public GameObject impact;
	public Animator animator;
	public AudioSource crossbowFireSound;
	public GameObject explosion;

	public GameController gamecontroller;

	// PRIVATE INSTANCE VARIABLES
	private GameObject[] _impacts;
	private int _currentImpact = 0;
	private int _maxImpacts = 5;

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
			animator.SetTrigger ("Fire");
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

				if(hit.transform.CompareTag("Barrel")){
					//destroy barrel object upon hit
					Destroy (hit.transform.gameObject);
					Instantiate(this.explosion, hit.point,Quaternion.identity);
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
















