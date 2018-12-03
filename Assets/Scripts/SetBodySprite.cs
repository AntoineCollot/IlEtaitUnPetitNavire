using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBodySprite : MonoBehaviour {

    [SerializeField]
    Sprite[] bodySprites;

	// Use this for initialization
	void Start () {
        Character character = GetComponentInParent<Character>();
        GetComponent<SpriteRenderer>().sprite = bodySprites[Mathf.Clamp(Mathf.FloorToInt(character.weight * bodySprites.Length),0,bodySprites.Length-1)];
	}
}
