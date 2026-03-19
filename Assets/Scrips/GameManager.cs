using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Biến để lưu trữ dữ liệu (ví dụ: Điểm số)
    public int score = 0;

    void Awake()
    {
        // Lệnh quan trọng nhất: Giữ GameObject này lại khi load Scene mới
        DontDestroyOnLoad(this.gameObject);
    }
}