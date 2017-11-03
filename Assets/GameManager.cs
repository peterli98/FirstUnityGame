using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public bool gameHasEnded = false;

	public float restartDelay = 4f;

	public void EndGame()
	{
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("GAME OVER");
			Invoke("Restart", restartDelay);
		}
	}

	public void CompleteLevel()
	{
		Debug.Log ("u did it");
	}

	void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
		
}
