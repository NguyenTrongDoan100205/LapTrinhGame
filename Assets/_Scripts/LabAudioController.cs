using UnityEngine;

public class LabAudioController : MonoBehaviour
{
    private AudioSource mySource;

    void Start()
    {
        // Lấy AudioSource
        mySource = GetComponent<AudioSource>();

        // Kiểm tra bắt buộc
        if (mySource == null)
        {
            Debug.LogError("❌ AudioSource NOT FOUND on this GameObject");
            return;
        }

        // Reset trạng thái audio toàn cục (tránh lỗi mute/pause trước đó)
        AudioListener.volume = 1f;
        AudioListener.pause = false;

        Debug.Log("✅ Audio system initialized. Press SPACE to play.");
    }

    void Update()
    {
        // Debug xác nhận Update có chạy
        if (Input.anyKeyDown)
        {
            Debug.Log("🎹 Key detected");
        }

        // Lab 1: Điều khiển phát
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mySource.Play();
            Debug.Log("▶ PLAY pressed | isPlaying = " + mySource.isPlaying);
        }

        // Lab 1: Điều khiển dừng
        if (Input.GetKeyDown(KeyCode.S))
        {
            mySource.Stop();
            Debug.Log("⏹ STOP pressed");
        }

        // Lab 3: Mute toàn cục
        if (Input.GetKeyDown(KeyCode.M))
        {
            AudioListener.volume = (AudioListener.volume == 0) ? 1 : 0;
            Debug.Log("🔇 Global Volume = " + AudioListener.volume);
        }

        // Lab 3: Pause toàn cục
        if (Input.GetKeyDown(KeyCode.P))
        {
            AudioListener.pause = !AudioListener.pause;
            Debug.Log("⏸ Global Pause = " + AudioListener.pause);
        }
    }
}
