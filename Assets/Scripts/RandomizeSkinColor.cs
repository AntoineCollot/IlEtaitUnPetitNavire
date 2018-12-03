using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSkinColor : MonoBehaviour {

    [SerializeField]
    SpriteRenderer[] spriteRenderer;

    public Color lightColor;
    public Color darkColor;

	// Use this for initialization
	void Start () {
        Color color = Color.Lerp(lightColor, darkColor, Random.value);

        foreach (SpriteRenderer r in spriteRenderer)
            r.color = color;
    }
}
