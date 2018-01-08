using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour {
	public bool IsSatIn { get; private set; } 

	public void BecomeSatIn(){
		IsSatIn = true;
		}

	public void BecomeUnsatIn() {
		IsSatIn = false;
		//ChairController.Instance.BecameAvailable (this);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
