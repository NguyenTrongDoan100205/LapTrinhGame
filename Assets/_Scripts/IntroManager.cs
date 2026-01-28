using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    [Header("Cấu hình Video")]
    public VideoPlayer introVideo;
    public string gameplaySceneName = "GameplayScene"; // Tên Scene tiếp theo

    [Header("Cấu hình UI")]
    public Button skipButton;

    void Start()
    {
        if (introVideo != null)
        {
            // Đăng ký sự kiện kết thúc video (Yêu cầu Lab 7)
            introVideo.loopPointReached += OnVideoEnd;
            introVideo.Play();
        }

        // Đăng ký sự kiện cho nút Skip
        if (skipButton != null)
        {
            skipButton.onClick.AddListener(OnSkipButtonClick);
        }
    }

    // Khi video tự chạy hết (Lab 7)
    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("🏁 Video kết thúc. Đang chuyển vào Gameplay...");
        StartGameplay();
    }

    // Khi người chơi chủ động nhấn Skip
    void OnSkipButtonClick()
    {
        Debug.Log("⏩ Người chơi đã bỏ qua Intro.");
        StartGameplay();
    }

    void StartGameplay()
    {
        // Giải phóng bộ nhớ và chuyển cảnh
        SceneManager.LoadScene(gameplaySceneName);
    }
}