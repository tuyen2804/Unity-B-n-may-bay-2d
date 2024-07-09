using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseBtn : SaiMonoBehaviour
{
    [SerializeField] public Button btn;
    protected override void Start()
    {
        base.Start();
        this.AddOnClickEvent();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadButton();
    }
    protected virtual void LoadButton()
    {
        if (this.btn != null) return;
        this.btn = GetComponent<Button>();
        Debug.Log(transform.name+":LoadButton", gameObject);
    }
    protected virtual void AddOnClickEvent()
    {
        this.btn.onClick.AddListener(this.OnClick);
    }
    protected virtual void OnClick()
    {

    }
}
