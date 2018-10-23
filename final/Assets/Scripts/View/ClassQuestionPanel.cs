using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassQuestionPanel : UIBase {
    public override UIType GetUIType()
    {
        return UIType.ClassQuestion;
    }

    protected override void Start()
    {
        base.Start();
        AddButtonLinstener("Question", QuestionClick);
    }

    private void QuestionClick(Button obj)
    {
        UIManager.Instance.OpenUICloseOthers(UIType.ClassDetail);
    }
}
