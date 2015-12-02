using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public Transform player;
	public float speed;

	//private Transform _transform;
	//private float distanceFromPlayer;

	// Use this for initialization
	void Start () {
		//this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		//this.distanceFromPlayer = Vector3.Distance (this._transform.position, this.player.position);

		//if (this.distanceFromPlayer < 1) {
		//	this._transform.position=Vector3.MoveTowards(this._transform.position,player.position,this.speed);
		//	Vector3 targetdir = this.player.position - this._transform.position;
		//	Vector3 newDir = Vector3.RotateTowards(transform.forward,targetdir,this.speed,0.0f);
		//	this._transform.rotation = Quaternion.LookRotation(newDir);
		//}

		transform.LookAt (player);
		//move constantly towards player
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, player.position, step);


	
	}
}
