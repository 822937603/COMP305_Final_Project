using UnityEngine;
using System.Collections;

public class EnemySpawnController : MonoBehaviour {

	public Transform spawnPoints;
	public GameObject enemy;
	public float spawnTime = 3f;

	// Use this for initialization
	void Start () {
	
		//invoke the spawns
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Spawn (){
	Instantiate (enemy,spawnPoints.position,spawnPoints.rotation);
		}
}
