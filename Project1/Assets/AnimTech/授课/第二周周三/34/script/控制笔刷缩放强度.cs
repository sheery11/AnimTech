using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class 控制笔刷缩放强度 : MonoBehaviour {
	static public float zoomIntensity;
	static public float rotationAngle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("mAmbientLightValue"+zoomIntensity);
	}

	void OnGUI(){
		GUI.Label(new Rect(15, 10, 70, 30), "缩放强度");
		zoomIntensity = GUI.HorizontalSlider(new Rect(80, 15, 100, 30),
			zoomIntensity, 0.2f, 10.0f);
		float index = zoomIntensity;
		GUI.Label(new Rect(190, 10, 40, 30), index.ToString());

		GUI.Label(new Rect(240, 10, 70, 30), "旋转速率");
		rotationAngle = GUI.HorizontalSlider(new Rect(300, 15, 100, 30),
			rotationAngle, 3.0f, 15.0f);
		float index2 = rotationAngle;
		GUI.Label(new Rect(410, 10, 40, 30), index2.ToString());

	}
}
