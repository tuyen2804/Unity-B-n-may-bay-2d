using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnExit : BaseBtn
{
    [SerializeField] public Transform pauseMenu;
    protected override void Awake()
    {
        this.pauseMenu = transform.parent.parent.Find("PanelPauseGame");
        // Kiểm tra xem pauseMenu đã được tìm thấy chưa
        if (pauseMenu != null)
        {
            // Nếu tìm thấy, thực hiện các hành động khác ở đây
            Debug.Log("PauseMenu found!");
        }
        else
        {
            // Nếu không tìm thấy, thông báo lỗi
            Debug.LogError("PauseMenu not found!");
        }
    }
    protected override void OnClick()
    {
        base.OnClick();
        Time.timeScale = 0f;
        
        pauseMenu.gameObject.SetActive(true);
    }
}
