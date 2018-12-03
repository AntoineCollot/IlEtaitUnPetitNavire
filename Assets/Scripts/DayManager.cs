using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DayManager : MonoBehaviour {

    public float timePerDay;
    float totalElapsedTime;
    int currentDay;

    public UnityEvent onNewDay = new UnityEvent();

    public static DayManager Instance;

    public int Day
    {
        get
        {
            return Mathf.FloorToInt(totalElapsedTime / timePerDay);
        }
    }

	// Use this for initialization
	void Awake () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Sail") && !GameManager.gameOver)
        {
            totalElapsedTime += Time.deltaTime;
            int day = Day;

            if (day>currentDay)
            {
                currentDay = day;
                onNewDay.Invoke();
            }
        }
	}
}
