using UnityEngine;
using UnityEngine.Video;

public class Lab7VideoEvents : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endPanel;

    void Start()
    {
        // Đảm bảo panel tắt ban đầu
        if (endPanel != null)
            endPanel.SetActive(false);

        // Đăng ký event
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        Debug.Log("✅ Lab 7 ready – Press V to prepare video");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("⏳ Preparing video...");
            videoPlayer.Prepare();
        }
    }

    // Event 1: Video prepare xong
    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("🎬 Video prepared → Play");
        vp.Play();
    }

    // Event 2: Video kết thúc
    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("🏁 Video finished!");

        if (endPanel != null)
        {
            endPanel.SetActive(true);
            Debug.Log("📺 End UI displayed");
        }

        // 👉 Nếu muốn chuyển scene (nâng cao)
        // SceneManager.LoadScene("NextScene");
    }
}
