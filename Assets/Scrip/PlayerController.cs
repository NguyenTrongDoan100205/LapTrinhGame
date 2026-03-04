using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Tốc độ di chuyển

    void Update()
    {
        // Lấy input từ bàn phím (Phím A/D hoặc Mũi tên Trái/Phải)
        float moveInput = Input.GetAxis("Horizontal");

        // Di chuyển tọa độ của nhân vật
        transform.position += new Vector3(moveInput * speed * Time.deltaTime, 0, 0);

        // Lật mặt nhân vật (Flip) khi đổi hướng
        if (moveInput > 0) transform.localScale = new Vector3(1, 1, 1);
        else if (moveInput < 0) transform.localScale = new Vector3(-1, 1, 1);
    }
}