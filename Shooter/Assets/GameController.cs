/*using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject hazard;
	//public GameObject hazard2;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public GUIText End;
	public GUIText Restart;
	public GUIText RestartInHand;
	private bool End1, Restart1;
	private int Score;
	void Start ()
	{
		StartCoroutine (SpawnWaves ());
		End.text = "";
		Restart.text = "";
		RestartInHand .text= "";
		End1 = false;
		Restart1 = true;
		Score = 0;
		//UpdateScores ();
	}
	void Update()
	{
		if(Restart1)
		{
			if(Input.GetKeyDown(keyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
			
		IEnumerator SpawnWaves ()
	{	
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Instantiate (hazard, spawnPosition, transform.rotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
			if(gameover)
			{
				Restart.text ="Press 'R' for Restart";
				Restart1=true;
				break;
			}
		}
	}
	}
public void UpdateScore()
{
	score+=newScoreValue;
	UpdareScore();
}
	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore();
	}
	public void GameOver()
	{
		End.text="Game Over!";
		End1=true;
	}
}*/