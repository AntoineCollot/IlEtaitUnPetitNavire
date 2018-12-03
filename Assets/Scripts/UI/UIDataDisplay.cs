using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDataDisplay : MonoBehaviour {

    [SerializeField]
    TextMeshProUGUI dayCountText;

    [SerializeField]
    Image progressBarHunger;

    [SerializeField]
    Image progressBarMood;

    [SerializeField]
    Image progressBarShape;

	
	// Update is called once per frame
	void LateUpdate () {
        dayCountText.text = DayManager.Instance.Day.ToString();
        progressBarHunger.fillAmount = BoatState.Instance.hunger;
        progressBarMood.fillAmount = BoatState.Instance.mood;
        progressBarShape.fillAmount = BoatState.Instance.boatShape;
    }
}
