using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurers : MonoBehaviour {

	public GameObject adventurer;
	public GameObject seat;
	public Chair chair;

	// Use this for initialization
	void Start () {
		adventurer = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		


	void OnMouseDown (){
		//Chair.BecomeUnSatIn();
		Destroy (adventurer);
//		GetComponent ();
		}

	public void GiveChair(Chair chair) {
		this.chair = chair;
	}

	}

