using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public float weight;
    public float RealWeight
    {
        get
        {
            return Mathf.Lerp(0.3f, 1.0f, weight);
        }
    }
    public float fun;
    public float woodworking;
    public float sailing;
    public float fishing;
    public float eyesight;
    public float appetite;
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AssignRandomValues()
    {
        weight = Random.value;
        fun = Random.value;
        woodworking = Random.value;
        sailing = Random.value;
        fishing = Random.value;
        eyesight = Random.Range(0.2f, 1.0f);
        appetite = Random.Range(0.3f, 1.0f);
    }
}
