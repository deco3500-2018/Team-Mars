using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : UIBase
{
    public override UIType GetUIType()
    {
        return UIType.Setting;
    }

    protected override void Start()
    {
        base.Start();
        AddButtonLinstener("LanguageButton", LanguageButtonClick);
    }

    private void LanguageButtonClick(Button obj)
    {
        UIManager.Instance.OpenUICloseOthers(UIType.LanguageSetting);
    }
}
