using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 我最美 : MonoBehaviour {

	public Color altColor = Color.black;
	public Renderer rend; 

	//I do not know why you need this?
	void Example() {         
		altColor.g = 0f;         
		altColor.r = 0f;        
		altColor.b = 0f;         
		altColor.a = 0f;     
	}      
		
	void Start () {
		
		Example();
		rend = GetComponent<Renderer>();
		rend.material.color = altColor;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.G)){           
			altColor.g += Random.Range (0f, 0.5f);
			rend.material.color = altColor;
		}
		if (Input.GetKeyDown (KeyCode.R)){           
			altColor.r += Random.Range (0f, 0.5f); 
			rend.material.color = altColor;
		}
		if (Input.GetKeyDown (KeyCode.B)){          
			altColor.b += Random.Range (0f, 0.5f); 
			rend.material.color = altColor;
		}
		if (Input.GetKeyDown (KeyCode.A)){         
			altColor.a += Random.Range (0f, 0.5f); 
			rend.material.color = altColor;
		}

		/*if (Input.GetMouseButtonDown (0)) {
			altColor.g += Random.Range (0f, 0.5f);
			altColor.r += Random.Range (0f, 1f);
			altColor.b += Random.Range (0f, 1f);

			rend.material.color = altColor;
		}*/
	}
}
