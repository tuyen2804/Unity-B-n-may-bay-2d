using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnLv2 : BaseBtn
{
    [SerializeField] public Transform completeLV1;
    // Start is called before the first frame update
    protected override void OnClick()
    {
        base.OnClick();
        if (CheckwWin.Instance.onLv2 == false)
        {
            this.TrueCompleteLV1();
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
    protected override void Awake()
    {
        this.completeLV1 = transform.parent.parent.Find("CompleteLV1");
        // Kiểm tra xem pauseMenu đã được tìm thấy chưa
        if (completeLV1 != null)
        {
            // Nếu tìm thấy, thực hiện các hành động khác ở đây
            Debug.Log("completeLV1 found!");
        }
        else
        {
            // Nếu không tìm thấy, thông báo lỗi
            Debug.LogError("completeLV1 not found!");
        }
    }
    public void TrueCompleteLV1()
    {

        completeLV1.gameObject.SetActive(true);
    }
    public void FalseCompleteLV1()
    {

        completeLV1.gameObject.SetActive(false);
    }
}
