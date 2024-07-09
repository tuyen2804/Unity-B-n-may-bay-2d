
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerReceiveDamage : MonoBehaviour
{
    private int currentHealth=10; // Máu hiện tại của thuyền địch
    private float timecount = 0f;
    private float timeUpdate = 2f;
    private bool onUpdate=false;
    public void FixedUpdate()
    {
        if (this.onUpdate)
        {
            this.timecount += Time.fixedDeltaTime;
            if (this.timecount < this.timeUpdate)
            {
                Shoot.Instance.shootDelay = 0.2f;
            }
            else
            {
                this.timecount = 0f;
                Shoot.Instance.shootDelay = 0.6f;
                this.onUpdate= false;

            }
        }
        
    }
    public void TakeDamage(int damage)
    {
        this.currentHealth -= damage; // Giảm máu theo damage nhận được
        HP.Instance.ChangeTextContent(this.currentHealth);

        // Kiểm tra nếu máu đã hết
        if (currentHealth <= 0)
        {
           
            SceneManager.LoadScene(0);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item_1"))
        {
            this.onUpdate = true;
            DeleteItem.Instance.DeleteObject();

        }
    }
}
