using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatCrew : MonoBehaviour {

    public int CrewCount
    {
        get
        {
            int count = 0;
            foreach (CharacterSlot slot in crew)
            {
                if (slot.character != null)
                    count++;
            }
            return count;
        }
    }

    public float CrewAppetite
    {
        get
        {


            float appetite = 0;
            foreach(CharacterSlot slot in crew)
            {
                if (slot.character != null)
                    appetite += slot.character.appetite;
            }
            return appetite / maxCrewCount;
        }
    }

    public float CrewWoodworking
    {
        get
        {
            float woodworking = 0;
            foreach (CharacterSlot slot in crew)
            {
                if (slot.character != null)
                    woodworking += slot.character.woodworking;
            }
            return woodworking / maxCrewCount;
        }
    }

    public float CrewFun
    {
        get
        {
            int crewCount = CrewCount;
            if (crewCount == 0)
                return 0;

            float fun = 0;
            foreach (CharacterSlot slot in crew)
            {
                if (slot.character != null)
                    fun += slot.character.fun;
            }
            return fun / crewCount;
        }
    }

    public float CrewSailing
    {
        get
        {
            float sailing = 0;
            foreach (CharacterSlot slot in crew)
            {
                if(slot.character!=null)
                    sailing += slot.character.sailing;
            }
            return sailing / maxCrewCount;
        }
    }

    public float maxCrewCount
    {
        get
        {
            return crew.Length;
        }
    }
    public CharacterSlot[] crew;

    public static BoatCrew Instance;

	// Use this for initialization
	void Awake () {
        Instance = this;
	}

    void Start()
    {
        for (int i = 0; i < maxCrewCount; i++)
        {
            Character newCrewMember = CharacterGenerator.Instance.GenerateNewRandomCharacter(transform);
            crew[i].Drop(newCrewMember.GetComponent<Draggable>(),true);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (CrewCount == 0)
            GameManager.Instance.GameOver();
    }
}
