using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager {
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null) 
            {
                instance = new UIManager();
            }
            return instance;
        }
    }

    private Dictionary<UIType, UIBase> uiDic = new Dictionary<UIType, UIBase>();

    private UIManager()
    {

    }

    public void AddUIPanel(UIType uiType,UIBase uibase)
    {
        uiDic.Add(uiType, uibase);
    }

    public void OpenUI(UIType showUIType)
    {
        if (uiDic.ContainsKey(showUIType))
        {
            uiDic[showUIType].ShowUI();
            Debug.Log("Open Panel：" + showUIType.ToString());
        }
        else
        {
            Debug.Log("UI No Exist：" + showUIType.ToString());
        }
    }

    public void CloseUI(UIType closeUIType)
    {
        if (uiDic.ContainsKey(closeUIType))
        {
            uiDic[closeUIType].CloseUI();
        }
    }
		
    public void OpenUI(UIType showUIType,UIType closeUIType)
    {
        if (uiDic.ContainsKey(closeUIType))
        {
            uiDic[closeUIType].CloseUI();
        }

        if (uiDic.ContainsKey(showUIType))
        {
            uiDic[showUIType].ShowUI();
            Debug.Log("Open UI：" + showUIType.ToString());
        }
        else
        {
            Debug.Log("UI is not existed：" + showUIType.ToString());
        }
    }

    public void OpenUICloseOthers(UIType showUIType)
    {
        Debug.Log("Open UI：" + showUIType.ToString());
        foreach (var item in uiDic)
        {
            item.Value.CloseUI();
            if (item.Key == showUIType)
            {
                item.Value.ShowUI();
            }
        }
    }
		
    public UIBase GetUIBase(UIType uiType)
    {
        UIBase uiBase = null;
        uiDic.TryGetValue(uiType, out uiBase);
        return uiBase;
    }

}

public enum UIType
{
    Main,
    OralAssiatant,
    ClassQuestion,
    VocabularyList,
    Setting,
    ClassDetail,
    LanguageSetting,
    MyVocabularyList,
    ShowDetail,
	Accuracy,
	Event
}

