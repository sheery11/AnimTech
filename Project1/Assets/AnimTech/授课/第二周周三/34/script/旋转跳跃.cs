using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 旋转跳跃 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float 旋转速率;
		if (控制笔刷缩放强度.rotationAngle == 0)
			旋转速率 = 3.0f;
		else
			旋转速率 = 控制笔刷缩放强度.rotationAngle;
		transform.Rotate (Vector3.forward,旋转速率);
	}
}
