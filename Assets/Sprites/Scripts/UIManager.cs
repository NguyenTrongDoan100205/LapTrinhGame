using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện để quản lý chuyển cảnh

public class UIManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject settingsPanel; // Kéo bảng Options vào đây

    // 1. Hàm bắt đầu game
    public void StartGame()
    {
        Debug.Log("--- Bat dau Game! ---");
        // Nếu bạn có Scene tiếp theo, hãy dùng: SceneManager.LoadScene(1);
    }

    // 2. Hàm mở/đóng bảng Options
    public void ToggleOptions(bool isOpen)
    {
        if (settingsPanel != null)
        {
            settingsPanel.SetActive(isOpen);
            Debug.Log("Bang Options dang: " + (isOpen ? "MO" : "DONG"));
        }
    }

    // 3. Hàm thoát game
    public void ExitGame()
    {
        Debug.Log("--- Dang thoat khoi ung dung... ---");
        Application.Quit(); // Lưu ý: Chỉ hoạt động sau khi Build ra file .exe
    }
}