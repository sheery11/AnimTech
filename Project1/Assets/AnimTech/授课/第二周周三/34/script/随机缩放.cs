using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 随机缩放0 : MonoBehaviour {

	public float _缩放强度 = 0.10f;

    void Update()
    {
        //float v1, v2, s;
        //do
        //{
        //    v1 = 2.0f * Random.Range(0f, 1f) - 1.0f;
        //    v2 = 2.0f * Random.Range(0f, 1f) - 1.0f;
        //    s = v1 * v1 + v2 * v2;
        //} while (s >= 1.0f || s == 0f);

        //s = Mathf.Sqrt((-2.0f * Mathf.Log(s)) / s);
        Vector3 尺度变化量 = new Vector3(
            Random.Range(-0.01f * _缩放强度, 0.01f * _缩放强度),
            Random.Range(-0.001f * _缩放强度, 0.001f * _缩放强度), 0);
        //Vector3 尺度变化量 = new Vector3(
        //    v1*s,s,0);
        transform.localScale += 尺度变化量;

       
    }
}
