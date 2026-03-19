using UnityEngine;
// 1. THÊM THƯ VIỆN NÀY VÀO ĐỂ DÙNG TEXTMESHPRO
using TMPro;

public class GameDisplay : MonoBehaviour
{
    // 2. ĐỔI 'Text' THÀNH 'TextMeshProUGUI'
    public TextMeshProUGUI welcomeText;

    void Start()
    {
        // Lấy dữ liệu từ biến static và hiển thị
        // (Giả sử bạn đã làm đúng DataManager ở Lab 1)
        if (DataManager.PlayerName != "")
        {
            welcomeText.text = "Chào mừng: " + DataManager.PlayerName;
        }
        else
        {
            welcomeText.text = "Chào mừng người lạ!";
        }
    }
}