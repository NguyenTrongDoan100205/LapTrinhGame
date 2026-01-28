using UnityEngine;
using UnityEngine.Video;

public class LabVideoController : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer == null)
        {
            Debug.LogError("❌ VideoPlayer NOT FOUND on this GameObject");
            return;
        }

        Debug.Log("✅ Video system ready. Press V to play video.");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            videoPlayer.Play();
            Debug.Log("▶ VIDEO PLAY");
        }
    }
}
