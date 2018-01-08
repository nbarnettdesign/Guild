using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurers : MonoBehaviour {

	public GameObject adventurer;
	public GameObject seat;
	public Chair chair;
	public int strength;
	public int skill;
	public int will;

	// Use this for initialization
	void Start () {
		adventurer = gameObject;
		strength = Random.Range (1, 5);
		skill = Random.Range (1, 5);
		will = Random.Range (1, 5);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
		


	void OnMouseDown (){
		chair.BecomeUnsatIn();
		Destroy (adventurer);
//		GetComponent ();
		}

	public void GiveChair(Chair chair) {
		this.chair = chair;
	}

	}

