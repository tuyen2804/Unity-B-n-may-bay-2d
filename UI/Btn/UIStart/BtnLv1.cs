using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnLv1:BaseBtn
{
    protected override void OnClick()
    {
        base.OnClick();
        SceneManager.LoadScene(1);
    }
}
