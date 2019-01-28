﻿using System.Collections;
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

	}
}
