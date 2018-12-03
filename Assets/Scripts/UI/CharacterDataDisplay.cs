using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterDataDisplay : MonoBehaviour {

    public GameObject panel;
    public TextMeshProUGUI textName;
    public Image progressBarWeight;
    public Image progressBarFun;
    public Image progressBarWookworking;
    public Image progressBarSailing;
    public Image progressBarAppetite;

	// Update is called once per frame
	void Update () {

        Draggable currentDraggable = PlayerCursor.Instance.hoveredDraggable;
        if (currentDraggable != null && !currentDraggable.isDragging)
        {
            Character currentCharacter = currentDraggable.GetComponent<Character>();

            if (currentCharacter != null)
            {
                panel.SetActive(true);
                transform.position = currentCharacter.transform.position;

                textName.text = currentCharacter.name;
                progressBarWeight.fillAmount = currentCharacter.RealWeight;
                progressBarFun.fillAmount = currentCharacter.fun;
                progressBarWookworking.fillAmount = currentCharacter.woodworking;
                progressBarSailing.fillAmount = currentCharacter.sailing;
                progressBarAppetite.fillAmount = currentCharacter.appetite;

                return;
            }
        }

        panel.SetActive(false);
        return;
    }
}
