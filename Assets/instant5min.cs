using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class instant5min : MonoBehaviour
{
	//public float speed;
	public GameObject bolt2;
	public float time1;
	public Transform shotSpawn;
	void update(){
		while (true) {
				if (Time.time > time1)
			{
				Instantiate (bolt2, shotSpawn.position, shotSpawn.rotation);
				//bolt2.velocity = (transform.forward * speed);
				time1 = time1 + Time.time;
			}
		}
	}
}
