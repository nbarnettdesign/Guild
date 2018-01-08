using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurerSpawnScript : MonoBehaviour {



	public int totalNumberOfAdventurers = 4;
	public int mint = 5;
	public int maxt = 10;
	public List<GameObject> adventurerList = new List<GameObject> ();
	public bool occupied = false;
	public int spawnTime;
//	private GameObject chair;
	public GameObject person;

	public bool IsSatIn { get; private set; }

	void Start () {
//		chair = gameObject;
	}
	void Update () {
//		if (person == "None (Game Object)"){
//			occupied = false;
//		}
			
		if (occupied == false){
			EmptyChair ();
		}
	}

	public void BecomeSatIn(){
		IsSatIn = true;	
	}

	public void BecomeUnsatIn() {
		IsSatIn = false;
		//ChairController.Instance.BecameAvailable (this);

	}

	void EmptyChair (){
		spawnTime = Random.Range (mint,maxt);
		Debug.Log (spawnTime);
		Invoke("spawnadventurers", spawnTime);
	}

	void spawnadventurers(){
		Debug.Log ("Spawn");
		CancelInvoke();

		int randomNum = Random.Range (0, totalNumberOfAdventurers);
		Object objTemp = adventurerList [randomNum];
		Instantiate (objTemp,transform.TransformPoint(Vector3.forward), Quaternion.identity);
		occupied = true;
		// Start a new timer for the next random spawn
	}
}
