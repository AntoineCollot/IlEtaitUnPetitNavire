using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeHair : MonoBehaviour {

    [SerializeField]
    Sprite[] availableSprites;

	// Use this for initialization
	void Start () {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = availableSprites[Random.Range(0, availableSprites.Length)];
        sprite.color = Random.ColorHSV();
    }
}
