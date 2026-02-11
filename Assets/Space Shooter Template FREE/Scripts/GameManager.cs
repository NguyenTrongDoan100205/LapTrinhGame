using UnityEngine;
using UnityEngine.SceneManagement; // Cần thiết để tải lại màn chơi

public class GameManager : MonoBehaviour
{
    [Header("UI Components")]
    // Kéo thả CanvasGameOver từ Hierarchy vào ô này trong Inspector
    public GameObject gameOverCanvas;

    private void Start()
    {
        // Đảm bảo ẩn Canvas khi bắt đầu game
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(false);
        }

        // Đảm bảo thời gian chạy bình thường khi bắt đầu
        Time.timeScale = 1f;
    }

    // Hàm này sẽ được gọi khi người chơi thua
    public void ShowGameOver()
    {
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }

        // Dừng thời gian trong game (làm mọi thứ đứng im)
        Time.timeScale = 0f;
    }

    // Hàm để tải lại màn chơi (gắn vào nút Restart)
    public void RestartGame()
    {
        // Bật lại thời gian trước khi tải cảnh mới
        Time.timeScale = 1f;

        // Tải lại cảnh hiện tại
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}