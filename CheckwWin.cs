using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckwWin : MonoBehaviour
{
    private static CheckwWin instance;
    public static CheckwWin Instance { get { return instance; } }

    public bool onLv2 = false;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // Nếu đã tồn tại một instance khác, hủy bỏ GameObject hiện tại
            return;
        }

        instance = this;

        // Đảm bảo rằng GameObject này và tất cả các con của nó sẽ không bị hủy bỏ khi chuyển scene
        DontDestroyOnLoad(gameObject);
    }
}
