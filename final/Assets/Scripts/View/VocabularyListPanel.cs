using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VocabularyListPanel : UIBase {
    public GameObject prefab;

	private string[] words;
	public Text ResponseTextField;

    public override UIType GetUIType()
    {
        return UIType.VocabularyList;
    }

	private void OnEnable()
    {	
		IEnumerator coroutine = showVocabularyList();
		StartCoroutine (coroutine);
    }

	private IEnumerator showVocabularyList(){
		WWW wordData = new WWW ("http://localhost/dashboard/unity/db.php");
		yield return wordData;
		string wordDataString = wordData.text;
		words = wordDataString.Split('|');
		ResponseTextField.text = "";
		float height = 0.0f;
		if (words != null) {
			for (int i = 0; i < words.Length; i++) {
				if (!words [i].Equals("")) {
					height += 50.0f;
					ResponseTextField.GetComponent<RectTransform> ().sizeDelta = new Vector2 (494.6f, height);
					string word = words [i].Split(':')[0];
					string date = words [i].Split(':')[1];
					ResponseTextField.text += "- " + word + " (" + date + ")" + "\n";
				}
			}
		}
	}
}
