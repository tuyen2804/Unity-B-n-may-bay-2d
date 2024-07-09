using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed = 0.2f;
    private Material material;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        float offset = Time.time * scrollSpeed;
        material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
