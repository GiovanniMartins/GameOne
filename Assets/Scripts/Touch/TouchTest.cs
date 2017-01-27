using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void getInfoTouch(){
		Touch touch = Input.GetTouch (0);
		//Moviment direction of the touch
		Vector2 delta = touch.deltaPosition;
		Debug.Log (delta);
	}
}
