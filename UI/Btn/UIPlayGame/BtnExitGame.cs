using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnExitGame:BaseBtn
{
    protected override void OnClick()
    {
        base.OnClick();
        SceneManager.LoadScene(0);
    }

}
