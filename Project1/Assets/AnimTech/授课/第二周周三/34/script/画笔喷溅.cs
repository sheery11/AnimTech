using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 画笔喷溅 : MonoBehaviour {
	public float endPositionx;
	public float endPositiony;
	public float NextGaussian() {
		float v1, v2, s;
		do {
			v1 = 2.0f * Random.Range(0f,1f) - 1.0f;
			v2 = 2.0f * Random.Range(0f,1f) - 1.0f;
			s = v1 * v1 + v2 * v2;
		} while (s >= 1.0f || s == 0f);

		s = Mathf.Sqrt((-2.0f * Mathf.Log(s)) / s);
		//Debug.Log (v1 * s);
		endPositionx = v1 * s/2.0f;
		endPositiony = v1 * s/3.0f;
		return v1 * s;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1)) {
			//Debug.Log (Input.mousePosition.x );
			transform.Translate (NextGaussian()/20,NextGaussian()/30,0);
			//transform.position = Input.mousePosition / 21.0f - new Vector3 (NextGaussian()/2, NextGaussian()/20, 0);
		}

	}


}
