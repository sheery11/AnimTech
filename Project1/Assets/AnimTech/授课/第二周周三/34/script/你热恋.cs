using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 你热恋 : MonoBehaviour {
	//public float _缩放强度 = 控制笔刷缩放强度.mAmbientLightValue;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 尺度变化量 = new Vector3 (
			Random.Range(-0.01f*控制笔刷缩放强度.zoomIntensity,0.01f*控制笔刷缩放强度.zoomIntensity),
			Random.Range(-0.001f*控制笔刷缩放强度.zoomIntensity,0.001f*控制笔刷缩放强度.zoomIntensity),0);
		transform.localScale += 尺度变化量;
		Debug.Log (控制笔刷缩放强度.zoomIntensity);
	}
}
