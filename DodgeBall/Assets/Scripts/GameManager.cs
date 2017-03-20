using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public bool GameHasEnded = false;
	public float delay = 1f;
	public void EndGame()
	{
		if (GameHasEnded == false) {
			GameHasEnded = true;
			Debug.Log ("Enddddd");
			Invoke ("restart", delay);
		}
	}
	
	// Update is called once per frame
	void restart () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	
	}
}
