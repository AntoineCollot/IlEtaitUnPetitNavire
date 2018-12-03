using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentGenerator : MonoBehaviour {

    [SerializeField]
    Transform[] islandPrefab;

    public float baseRingIslandRadius;
    public float startRingIslandDistance;
    public float endRingIslandDistance;
    public int islandCount;

    public static Transform[] generatedIslands;

	// Use this for initialization
	void Start () {
        GenerateEnvironment();
    }

    void GenerateEnvironment()
    {
        float ringIslandRadius = baseRingIslandRadius;
        generatedIslands = new Transform[islandCount];

        for (int i = 0; i < islandCount; i++)
        {
            float randomDir = Random.value;
            Vector3 islandPos = new Vector2(Mathf.Cos(randomDir * 2 * Mathf.PI), Mathf.Sin(randomDir * 2 * Mathf.PI)) * ringIslandRadius;
            generatedIslands[i] = Instantiate(islandPrefab[Random.Range(0,islandPrefab.Length)], islandPos,Quaternion.identity, transform);

            ringIslandRadius += Mathf.Lerp(startRingIslandDistance, endRingIslandDistance, (float)i / islandCount);
        }
    }
}
