using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnContinueGame : BaseBtn
{
    protected override void OnClick()
    {
        base.OnClick();
        Time.timeScale = 1f;
        transform.parent.gameObject.SetActive(false);
    }
}
