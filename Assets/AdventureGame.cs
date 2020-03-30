using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
	// Variables
	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

	// Internal Variables
	State currentState;
	State previousState;

	// Debug


	// Start is called before the first frame update
	void Start() {
		currentState = startingState;
		textComponent.text = currentState.GetStateStory();
	}

	// Update is called once per frame
	void Update() {
		ManageState();
		textComponent.text = currentState.GetStateStory();
	}

	void ManageState() {
		State[] nextStates = currentState.GetNextStates();

		if(Input.GetKeyDown(KeyCode.Alpha1)) {
			currentState = nextStates[0];
		}

		if(Input.GetKeyDown(KeyCode.Alpha2)) {
			currentState = nextStates[1];
		}
	}
}
