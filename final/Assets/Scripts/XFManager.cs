using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XFManager : MonoBehaviour {

    public static XFManager Instance;
    public Text resultText;
    private AndroidJavaObject currentActivity;
    public Action<string> resultAction;

    private void Awake()
    {
        Instance = this;

        currentActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
    }

    public void StartRecord()
    {
        if (currentActivity != null)
            currentActivity.Call("StartLinsten");
    }

    public void OnResult(string text)
    {
        text = text.ToLower();
        resultText.text = text;
        if (resultAction != null) resultAction(text);
    }
}
