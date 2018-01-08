using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ChairController : Singleton<ChairController> {
	public string chairTag;
	public int totalNumberOfAdventurers = 4;
	public int mint = 5;
	public int maxt = 10;
	public List<GameObject> adventurerList = new List<GameObject> ();
	private List<Chair> chairs;
	private float currentSpawnTime;
	private float chairTimer;

	public void Awake() {
		chairs = new List<Chair>();

		foreach (GameObject chair in GameObject.FindGameObjectsWithTag(chairTag)) {
			chairs.Add(chair.GetComponent<Chair>());
		}

		SetSpawnTime();
	}

	private void Update() {
		CheckChairs();
	}

	private void CheckChairs() {
		chairTimer += Time.deltaTime;

		if (chairTimer <= currentSpawnTime)
			return;

		Chair c = GetEmptyChair();

		if(c != null) {
			SpawnAdventurer(c);
			SetSpawnTime();
		}

	}

	private Chair GetEmptyChair() {
		return chairs.Find(c => c.IsSatIn == false);
	}

	private void SpawnAdventurer(Chair chair) {
		chair.BecomeSatIn();

		int randomNum = Random.Range (0, totalNumberOfAdventurers);
		Object customers = adventurerList [randomNum];
		GameObject g = Instantiate (customers, chair.gameObject.transform.position, Quaternion.identity);
		Adventurers adventurer = g.GetComponent<Adventurers> ();
		adventurer.GiveChair (chair);
	}

	private void SetSpawnTime() {
		chairTimer = 0f;
		currentSpawnTime = Random.Range(mint, maxt);
	}
}
