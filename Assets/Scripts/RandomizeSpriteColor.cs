using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSpriteColor : MonoBehaviour {

    [SerializeField]
    SpriteRenderer[] spriteRenderer;

	// Use this for initialization
	void Start () {
        Color color = Random.ColorHSV();

        foreach (SpriteRenderer r in spriteRenderer)
            r.color = color;
    }
}
