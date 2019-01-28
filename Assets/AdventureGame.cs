using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

	string[] daysOfWeek = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };

	State currentState;

	// Use this for initialization
	void Start () {
		currentState = startingState;
		textComponent.text = currentState.GetStateStory ();
		foreach (string day in daysOfWeek) {
			Debug.Log (day);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
