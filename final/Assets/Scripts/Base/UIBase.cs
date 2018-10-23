using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class UIBase : MonoBehaviour {

    /// <summary>
    /// Return UI type
    /// </summary>
    public UIType returnUIType;
    public void ShowUI()
    {
        gameObject.SetActive(true);
    }

    public void CloseUI()
    {
        gameObject.SetActive(false);
    }

    protected virtual void Awake()
    {
        UIManager.Instance.AddUIPanel(GetUIType(), this);
    }

    protected virtual void Start()
    {
        UIManager.Instance.CloseUI(GetUIType());
        if(this.transform.Find("ReturnButton"))
        {
            AddButtonLinstener("ReturnButton", ReturnButtonClick);
        }
    }

    private void ReturnButtonClick(Button obj)
    {
        UIManager.Instance.OpenUICloseOthers(returnUIType);
    }

    protected void AddButtonLinstener(string path, Action<Button> action)
    {
        Button button = this.transform.Find(path).GetComponent<Button>();
        button.onClick.AddListener(()=> 
        {
            if (action != null) action(button);
        });
    }

    public abstract UIType GetUIType();
}
