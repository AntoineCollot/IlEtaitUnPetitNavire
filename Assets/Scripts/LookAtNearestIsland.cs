using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtNearestIsland : MonoBehaviour {

    Transform nearestIsland;

    public float minArrowDist;
    public float maxArrowDist;

    [SerializeField]
    SpriteRenderer arrow;

    void Start()
    {
        StartCoroutine(CheckNearestIsland());
    }

	// Use this for initialization
	void Update () {
        if (nearestIsland != null)
        {
            Color color = Color.white;
            color.a = Mathf.Lerp(0,0.3f,(Vector2.Distance(nearestIsland.position, transform.position)-minArrowDist)/(maxArrowDist-minArrowDist));
            arrow.color = color;
            transform.LookAt(nearestIsland);
        }
	}

    IEnumerator CheckNearestIsland()
    {

        while(true)
        {
            yield return new WaitForSeconds(1);

            float minDist = Mathf.Infinity;
           
            foreach (Transform t in EnvironmentGenerator.generatedIslands)
            {
                float dist = (transform.position - t.position).sqrMagnitude;
                if(dist< minDist)
                {
                    minDist = dist;
                    nearestIsland = t;
                }
            }
        }
    }
}
