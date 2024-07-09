using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteShipBoss : MonoBehaviour
{
    public int maxHealth = 10; // Máu tối đa của thuyền địch
    private int currentHealth; // Máu hiện tại của thuyền địch

    void Start()
    {
        currentHealth = maxHealth; // Khởi tạo máu ban đầu
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Giảm máu theo damage nhận được

        // Kiểm tra nếu máu đã hết
        if (currentHealth <= 0)
        {
            SpawnShipEnemy.Instance.Despawn(transform.parent);
            this.currentHealth = this.maxHealth;

            // Kiểm tra và cập nhật trạng thái của CheckwWin
            if (CheckwWin.Instance != null)
            {
                CheckwWin.Instance.onLv2 = true;
            }
            else
            {
                Debug.Log("CheckwWin instance is not initialized!");
            }

            // Load lại Scene
            SceneManager.LoadScene(0);
        }
    }
}
