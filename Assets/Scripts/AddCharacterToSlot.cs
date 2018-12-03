using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCharacterToSlot : MonoBehaviour {

    [Range(0,1)]
    public float spawnChance;

	// Use this for initialization
	void Start () {
        if (spawnChance >= Random.value)
        {
            Character newCharacter = CharacterGenerator.Instance.GenerateNewRandomCharacter(transform);
            GetComponent<CharacterSlot>().Init(newCharacter.GetComponent<Draggable>());
        }
    }
}
