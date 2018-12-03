using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSlot : Slot {

    public bool isEnabled;

    public Character character;

    public void Init(Draggable draggable)
    {
        Drop(draggable, true);
        draggable.transform.localPosition = Vector3.zero;
        ActivateSlot(isEnabled);
    }

    public override void Drop(Draggable newDraggable, bool ignoreEnabled=false)
    {
        if (!isEnabled && !ignoreEnabled)
            return;

        CharacterSlot otherSlot = newDraggable.slot;
        if(otherSlot!=null)
            otherSlot.draggable = draggable;

        if (draggable != null)
            draggable.AssignSlot(otherSlot);

        draggable = newDraggable;
        newDraggable.AssignSlot(this);

        UpdateCharacter();
        if (otherSlot != null)
            otherSlot.UpdateCharacter();
    }

    public void UpdateCharacter()
    {
        if (draggable != null)
            character = draggable.GetComponent<Character>();
        else
            character = null;
    }

    public void ActivateSlot(bool value)
    {
        isEnabled = value;
        if(draggable!=null)
            draggable.enabled = value;
    }
}
