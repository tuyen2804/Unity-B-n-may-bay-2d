using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 5f; // Tốc độ di chuyển của tàu

    //private Camera mainCamera; // Tham chiếu tới Camera chính

    //void Start()
    //{
    //    // Lấy tham chiếu tới Camera chính
    //    mainCamera = Camera.main;
    //}

    void Update()
    {
        // Nếu click chuột trái
        if (Input.GetMouseButton(0))
        {
            // Lấy vị trí của chuột trong không gian thế giới
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // Đặt z = 0 để đảm bảo đối tượng không di chuyển theo trục z

            // Giới hạn vị trí của tàu trong màn hình
            float clampedX = Mathf.Clamp(mousePosition.x, Camera.main.ViewportToWorldPoint(Vector3.zero).x, Camera.main.ViewportToWorldPoint(Vector3.one).x);
            float clampedY = Mathf.Clamp(mousePosition.y, Camera.main.ViewportToWorldPoint(Vector3.zero).y, Camera.main.ViewportToWorldPoint(Vector3.one).y);

            // Di chuyển tàu đến vị trí của chuột với tốc độ xác định
            transform.parent.position = Vector3.MoveTowards(transform.parent.position, new Vector3(clampedX, clampedY, 0), speed * Time.deltaTime);
        }
    }
}
