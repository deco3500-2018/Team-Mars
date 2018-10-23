using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OralAssiatantPanel : UIBase
{
    public override UIType GetUIType()
    {
        return UIType.OralAssiatant;
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
