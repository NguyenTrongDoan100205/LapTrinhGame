using UnityEngine;
using TMPro; // Đừng quên cái này để dùng Text (TMP)

public class HighScoreManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    private int currentHighScore = 0;

    void Start()
    {
        // 1. KHI BẮT ĐẦU: Đọc điểm cao từ bộ nhớ. 
        // Nếu chưa có (lần đầu chơi), nó sẽ lấy giá trị mặc định là 0.
        currentHighScore = PlayerPrefs.GetInt("HighScore", 0);

        // Hiển thị lên màn hình
        UpdateUI();
    }

    public void SaveNewScore(int newScore)
    {
        // 2. KHI CÓ ĐIỂM MỚI: Kiểm tra xem có cao hơn điểm cũ không
        if (newScore > currentHighScore)
        {
            currentHighScore = newScore;

            // Lưu vào bộ nhớ máy
            PlayerPrefs.SetInt("HighScore", currentHighScore);

            // Lệnh quan trọng: Ép Unity ghi dữ liệu xuống đĩa ngay lập tức
            PlayerPrefs.Save();

            UpdateUI();
            Debug.Log("Đã lưu kỷ lục mới: " + currentHighScore);
        }
    }

    void UpdateUI()
    {
        highScoreText.text = "Kỷ lục: " + currentHighScore.ToString();
    }

    // Hàm này để bạn test thử bằng nút bấm
    public void TestAddScore()
    {
        SaveNewScore(100); // Thử lưu 100 điểm
    }
}