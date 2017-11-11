using System.Collections;
using UnityEngine;

public class Generator : MonoBehaviour {
 
	public int numberOfObstacle = 22;
	public int xMin = -8;
	public int xMax = 8;

	// Use this for initialization
	void Start () 
	{
		GameObject obstaclePrefab = Resources.Load("ObstaclePrefab") as GameObject;
		PlaceObstacles (obstaclePrefab);
	}

	void PlaceObstacles(GameObject obstacle) 
	{
		for (int i = 1; i <= numberOfObstacle; i++) 
		{
			Instantiate (obstacle, GeneratedPositions(1, i*10), Quaternion.identity);
		}
	}
	
	Vector3 GeneratedPositions(int y, int z)
	{
		int x;
		x = UnityEngine.Random.Range (xMin, xMax);

		return new Vector3 (x, y, z);
	}
}
