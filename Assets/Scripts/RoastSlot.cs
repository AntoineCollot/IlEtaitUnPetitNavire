using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoastSlot : Slot {

    public override void Drop(Draggable newDraggable, bool ignoreEnabled = false)
    {
        Character character = newDraggable.GetComponent<Character>();
        if (character != null)
        {
            //Remove the character from its old slot
            newDraggable.slot.draggable = null;
            newDraggable.slot.character = null;

            BoatState.Instance.Eat(character.RealWeight);
            Destroy(newDraggable.gameObject);
            GetComponentInChildren<Animator>().SetTrigger("Roast");
        }
    }
}
