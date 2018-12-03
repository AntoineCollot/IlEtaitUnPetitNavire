using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWater : MonoBehaviour {

    public float cellSize = 100;

    [SerializeField]
    Transform boat;
	
	// Update is called once per frame
	void LateUpdate () {
        float xPos = Mathf.Round(boat.position.x / cellSize) * cellSize;
        float yPos = Mathf.Round(boat.position.y / cellSize) * cellSize;
        transform.position = new Vector3(xPos, yPos, 0);
	}
}
