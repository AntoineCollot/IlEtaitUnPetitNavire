using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour {

    public float baseSpeed;
    public float maxSpeedMultiplier;

    Vector3 refInput;
    public float movementSmooth;

    Vector3 inputDirection;
    Rigidbody2D r;

    void Awake()
    {
        r = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        refInput = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 newDirection = Vector3.zero;

        if (Input.GetButton("Sail") && !GameManager.gameOver)
        {
            newDirection = Input.mousePosition - new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);
            newDirection.Normalize();
        }

        inputDirection = Vector3.SmoothDamp(inputDirection, newDirection, ref refInput, movementSmooth);
    }

    void FixedUpdate()
    {
            r.velocity = inputDirection * baseSpeed * Mathf.Lerp(1, maxSpeedMultiplier, BoatCrew.Instance.CrewSailing);
    }
}
