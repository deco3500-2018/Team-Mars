using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reset_text : MonoBehaviour {
	[Tooltip("Text field to display the initial text of streaming.")]
	public Text ResultsField;
	public Button Smile;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}	

	public void TaskOnClick(){
		ResultsField.text = "Speaking";
		Smile.gameObject.SetActive (false);
	}
}
