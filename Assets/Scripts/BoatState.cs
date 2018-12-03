using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatState : MonoBehaviour {

    [HideInInspector]
    public float hunger;
    [HideInInspector]
    public float mood;
    [HideInInspector]
    public float boatShape;

    [Header("Variations Per Day")]
    public float appetiteMultiplier;
    public float moodVariations;
    public float boatShapeVariations;

    [Header("Eating")]
    public float eatingMultiplier;

    BoatCrew crew;

    public static BoatState Instance;

	void Awake () {
        Instance = this;
        crew = GetComponentInChildren<BoatCrew>();
    }

    void Start()
    {
        hunger = 1;
        mood = 1;
        boatShape = 1;
    }

    public void Update()
    {
        if (Input.GetButton("Sail") && !GameManager.gameOver)
        {
            //Hunger
            hunger -= crew.CrewAppetite* appetiteMultiplier * Time.deltaTime;

            //Mood
            mood += Mathf.Lerp(-moodVariations, moodVariations, crew.CrewFun) * Time.deltaTime;

            //Boat Shape
            boatShape += Mathf.Lerp(-boatShapeVariations, boatShapeVariations, crew.CrewWoodworking) * Time.deltaTime;

            //Check for game over
            if (hunger <= 0 || mood <= 0 || boatShape <= 0)
                GameManager.Instance.GameOver();

            //Clamp all values
            hunger = Mathf.Clamp01(hunger);
            mood = Mathf.Clamp01(mood);
            boatShape = Mathf.Clamp01(boatShape);
        }
    }

    public void Eat(float weight)
    {
        hunger += weight * eatingMultiplier;
        hunger = Mathf.Clamp01(hunger);
    }
}
