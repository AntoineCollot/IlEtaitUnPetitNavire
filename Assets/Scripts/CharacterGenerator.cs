using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGenerator : MonoBehaviour {

    [SerializeField]
    Character characterPrefab;

    public static CharacterGenerator Instance;

	// Use this for initialization
	void Awake () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Character GenerateNewRandomCharacter(Transform parent)
    {
        Character newCharacter = Instantiate(characterPrefab, parent);
        newCharacter.AssignRandomValues();
        newCharacter.name = NameGenerator.GetRandomName();


        return newCharacter;
    }
}
