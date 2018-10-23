using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : UIBase {
    protected override void Start()
    {
        AddButtonLinstener("OralAssiatant", OpenUIPanel);
        AddButtonLinstener("ClassQuestion", OpenUIPanel);
        AddButtonLinstener("VocabularyList", OpenUIPanel);
        AddButtonLinstener("Setting", OpenUIPanel);
		AddButtonLinstener("Accuracy", OpenUIPanel);
		AddButtonLinstener("Event", OpenUIPanel);
    }

    private void OpenUIPanel(Button obj)
    {
        UIManager.Instance.OpenUICloseOthers((UIType)Enum.Parse(typeof(UIType), obj.name));
    }

    public override UIType GetUIType()
    {
        return UIType.Main;
    }
}
