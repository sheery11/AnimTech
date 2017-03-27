using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 随机变色 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SpriteRenderer star;
		star = GetComponent<SpriteRenderer> ();
		Color color = Random.ColorHSV ();
		color.r = Random.Range (0.0f, 1.0f);
		star.color = color;
	}
}
