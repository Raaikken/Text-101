using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
	// Variables
	[TextArea(2, 20)] [SerializeField] string titleText;
	[TextArea(20, 20)] [SerializeField] string storyText;
	[SerializeField] State[] nextStates;

	// Internal Variables


	// Debug

	public string GetStateStory(){
		return storyText;
	}

	public string GetStateTitle(){
		return titleText;
	}

	public string[] GetAllStateText(){
		string[] stateTexts = new string[2];
		stateTexts[0] = titleText;
		stateTexts[1] = storyText;
		return stateTexts;
	}

	public State[] GetNextStates() {
		return nextStates;
	}
}
