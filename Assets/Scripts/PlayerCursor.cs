using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCursor : MonoBehaviour
{
    Camera cam;
    public static PlayerCursor Instance;

    [HideInInspector]
    public Draggable hoveredDraggable;

    public LayerMask interactionLayer;

    public Vector3 WorldPosition
    {
        get
        {
            return cam.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    public Ray CursorRay
    {
        get
        {
            return cam.ScreenPointToRay(Input.mousePosition);
        }
    }

    // Use this for initialization
    void Awake()
    {
        cam = Camera.main;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = CursorRay;

        RaycastHit2D hit = Physics2D.Raycast(CursorRay.origin, CursorRay.direction, 15, interactionLayer);

        //If we hit something
        if (hit.collider != null)
        {
            //Hovering
            Draggable interactableHit = hit.collider.GetComponent<Draggable>();

            if (interactableHit != hoveredDraggable)
            {
                if (hoveredDraggable != null)
                    hoveredDraggable.OffHover();

                hoveredDraggable = interactableHit;

                if (hoveredDraggable != null)
                    hoveredDraggable.OnHover();
            }

            //Click
            if (interactableHit != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    interactableHit.OnClick();
                }
            }
        }
        else
        {
            if (hoveredDraggable != null)
            {
                hoveredDraggable.OffHover();
                hoveredDraggable = null;
            }

        }
    }


}
