using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpecialCar1 : MonoBehaviour {

	public GameObject carSpecial1 ; 
	public float spawnTime = 12f; 
	public Transform[] spawnPoints; 

	private int k ; 
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn",7f,spawnTime); 
	}

	// Update is called once per frame
	void Spawn ()
	{
		k = Random.Range (0,5);
		//Vector3 carPos = new Vector3(Random.Range(0.56f,0.56f),transform.position.y,transform.position.z) ;
		int spawnPointIndex = Random.Range (0, spawnPoints.Length); 
		if (k == 1)
		{
			Vector3 carPos1 = new Vector3(Random.Range(-1.61f, -1.61f), transform.position.y, transform.position.z);
			Instantiate(carSpecial1, carPos1, spawnPoints [spawnPointIndex].rotation);

		}
		if (k == 2)
		{
			Vector3 carPos2 = new Vector3(Random.Range(-0.53f, -0.53f), transform.position.y, transform.position.z);
			Instantiate(carSpecial1, carPos2, spawnPoints [spawnPointIndex].rotation);

		}
		if (k == 3)
		{
			Vector3 carPos3 = new Vector3(Random.Range(0.56f, 0.56f), transform.position.y, transform.position.z);
			Instantiate(carSpecial1, carPos3,spawnPoints [spawnPointIndex].rotation);

		}
		if (k == 4)
		{
			Vector3 carPos4 = new Vector3(Random.Range(1.63f, 1.63f), transform.position.y, transform.position.z);
			Instantiate(carSpecial1, carPos4, spawnPoints [spawnPointIndex].rotation);

		}
		//int spawnPointIndex = Random.Range (0, spawnPoints.Length); 

		//Instantiate (carSpecial1, carPos, spawnPoints [spawnPointIndex].rotation); 
	}
}
