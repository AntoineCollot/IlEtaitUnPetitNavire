using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectShipProximity : MonoBehaviour {

    CharacterSlot[] slot;

	void Awake () {
        slot = GetComponentsInChildren<CharacterSlot>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boat")
        {
            foreach(CharacterSlot cs in slot)
                cs.ActivateSlot(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Boat")
        {
            foreach (CharacterSlot cs in slot)
                cs.ActivateSlot(false);
        }

    }
}
