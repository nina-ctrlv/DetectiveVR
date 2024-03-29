﻿using UnityEngine;
using System.Collections;

public class ObjectMotherClass : MonoBehaviour {
	public Camera cam;
	public GameObject target;
	public int i;
	public string description;

	public void Start()
	{

		if(cam == null) {
			cam = (Camera) GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<Camera>();
		}
		if(target == null) {
			target = GameObject.FindGameObjectsWithTag("Target")[0];
		}
	}

	public void Update(){
		Distance ();
	
	}

	public void Distance(){
		var gameObZ = transform.position.z;
		var gameObX = transform.position.x;
		var camZ = cam.transform.position.z;
		var camX = cam.transform.position.x;
		float X = gameObX - camX;
		float Z = gameObZ - camZ;
		float distSquare = Z * Z + X * X;
		float dist = Mathf.Sqrt (distSquare);
		//Debug.Log ("x="+X+", z="+Z+",distance="+dist);
		if (dist <= 10f) {
			target.gameObject.SetActive (true);
	
		}
	}


}