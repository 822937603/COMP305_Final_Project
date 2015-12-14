using UnityEngine;
using System.Collections;

public class RestartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnStartButtonClick() {
		Application.LoadLevel ("An_Ancient_Score_Level_01");
	}
}
