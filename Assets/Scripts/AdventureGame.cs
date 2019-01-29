using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

	[SerializeField] Text textComponent;
	[SerializeField] State startingState;
	[SerializeField] State endState;

	State currentState;

	/**
	 * This function is called once at the beginning of the game. 
	 * Initialize elements, and do initial settings here.
	 */
	void Start () {
		currentState = startingState;
		textComponent.text = currentState.GetStateStory ();
	}

	/**
	 * Update is called once every frame.
	 * Here we check if quit or restart key is pressed.
	 * If not, then change state as per user's input
	 */
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			currentState = endState;
		} else if (Input.GetKeyDown (KeyCode.Space)) {
			currentState = startingState;
		} else {
			ManageState ();
		}
		textComponent.text = currentState.GetStateStory ();
	}

	/**
	 * Change to next state as per user's input
	 */
	private void ManageState () {
		var nextStates = currentState.GetNextStates ();
		if (Input.GetKeyDown (KeyCode.Keypad1) || Input.GetKeyDown (KeyCode.Alpha1) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			if (nextStates.Length >= 1) {
				currentState = currentState.GetNextStates () [0];
			}
		} else
		if (Input.GetKeyDown (KeyCode.Keypad2) || Input.GetKeyDown (KeyCode.Alpha2) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.RightArrow)) {
			if (nextStates.Length >= 2) {
				currentState = currentState.GetNextStates () [1];
			}
		}
	}
}
