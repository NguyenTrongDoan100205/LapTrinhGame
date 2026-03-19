using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Ô này để kéo file ScriptableObject vào
    public GameConfig config;

    void Start()
    {
        if (config != null)
        {
            Debug.Log("Tên vật phẩm: " + config.itemName);
            Debug.Log("Tốc độ di chuyển: " + config.moveSpeed);
            // Bạn có thể dùng config.moveSpeed để gán cho nhân vật di chuyển
        }
    }
}