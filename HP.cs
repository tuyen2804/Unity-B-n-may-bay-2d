using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HP : SaiMonoBehaviour
{
    private static HP instance;
    [SerializeField] public static HP Instance { get {  return instance; } }
    protected override void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Only 1 HP allow to exist");
        }
        instance = this;
        textMeshPro = GetComponent<TMP_Text>();
    }
    public TMP_Text textMeshPro;

    // Hàm này có thể được gọi từ bất kỳ nơi nào trong script của bạn để thay đổi văn bản
    public void ChangeTextContent(int newText)
    {
        textMeshPro.text = newText.ToString();
    }
}
