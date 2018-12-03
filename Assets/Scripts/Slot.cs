using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Slot : MonoBehaviour {

    [HideInInspector]
    public Draggable draggable;

    protected Draggable dragging;

    public UnityEvent onItemChanged = new UnityEvent();

    // Update is called once per frame
    protected void Update()
    {
        if (Input.GetMouseButtonUp(0) && dragging != null)
            Drop(dragging);
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        Draggable hitDraggable = other.GetComponent<Draggable>();
        if (hitDraggable != null)
        {
            dragging = hitDraggable;
        }
    }

    protected void OnTriggerExit2D(Collider2D other)
    {
        Draggable hitDraggable = other.GetComponent<Draggable>();
        if (hitDraggable != null)
        {
            dragging = null;
        }
    }

    public abstract void Drop(Draggable newDraggable, bool ignoreEnabled = false);
}
