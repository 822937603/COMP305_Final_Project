
//Franco Chong
//File: MenuController.cs
// Controls the collider of the portal

using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

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
