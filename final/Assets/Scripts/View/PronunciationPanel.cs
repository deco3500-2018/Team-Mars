using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PronunciationPanel : UIBase
{
    public override UIType GetUIType()
    {
		return UIType.Accuracy;
    }


    protected override void Start()
    {
        base.Start();
        AddButtonLinstener("Speaking", SpeakingButtonClick);
    }

    private void OnValueChange(string arg0)
    {
        XFManager.Instance.resultAction(arg0);
    }

    private void SpeakingButtonClick(Button obj)
    {
        XFManager.Instance.StartRecord();
    }

}
