using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

	State currentState;

	// Use this for initialization
	void Start () {
		currentState = startingState;
		textComponent.text = currentState.GetStateStory ();
	}

	// Update is called once per frame
	void Update () {
		ManageState ();
		textComponent.text = currentState.GetStateStory ();
	}

	private void ManageState () {
		var nextStates = currentState.GetNextStates ();
		if (Input.GetKeyDown (KeyCode.Keypad1) || Input.GetKeyDown (KeyCode.Alpha1) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			if (nextStates.Length >= 1) {
				currentState = currentState.GetNextStates () [0];
			}
		} else if (Input.GetKeyDown (KeyCode.Keypad2) || Input.GetKeyDown (KeyCode.Alpha2) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.RightArrow)) {
			if (nextStates.Length >= 2) {
				currentState = currentState.GetNextStates () [1];
			}
		}
	}
}
