using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Draggable : MonoBehaviour {

    [HideInInspector]
    public bool isDragging;

    public float backToSlotTime = 1;
    [HideInInspector]
    public CharacterSlot slot;

    Vector3 refPosition;
    public float freeMovementSmooth;

    Animator anim;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Use this for initialization
    void Start () {
        slot = GetComponentInParent<CharacterSlot>();
        transform.localPosition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isDragging)
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, Vector3.zero, ref refPosition, freeMovementSmooth);
	}

    public void AssignSlot(CharacterSlot newSlot)
    {
        slot = newSlot;
        refPosition = Vector3.zero;
        transform.SetParent(slot.transform,true);
    }

    public void OnClick()
    {
        if(enabled)
            StartCoroutine(Drag());
    }

    public void OnHover()
    {
        if (enabled)
            anim.SetBool("IsHovered", true);
    }

    public void OffHover()
    {
        anim.SetBool("IsHovered", false);
    }

    IEnumerator Drag()
    {
        anim.SetBool("IsDragging", true);

        isDragging = true;
        Vector3 offset = transform.position - PlayerCursor.Instance.WorldPosition;

        while (Input.GetMouseButton(0))
        {
            transform.position = PlayerCursor.Instance.WorldPosition + offset;

            yield return null;
        }

        isDragging = false;
        anim.SetBool("IsDragging", false);
    }
}
