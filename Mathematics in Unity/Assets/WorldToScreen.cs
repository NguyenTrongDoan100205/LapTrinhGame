using UnityEngine;


public class WorldToScreen : MonoBehaviour
{
    void Update()
    {
        // Chuyển đổi tọa độ thế giới của Cube sang tọa độ màn hình Pixel
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        // In kết quả ra bảng Console
        Debug.Log("Screen Position: " + screenPos);
    }
}