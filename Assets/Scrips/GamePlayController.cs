using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    void Start()
    {
        // 1. Đi tìm đối tượng tên "GameManager" trong toàn bộ Scene
        GameObject findObj = GameObject.Find("GameManager");

        if (findObj != null)
        {
            // 2. Lấy Script GameManager gắn trên đối tượng đó
            GameManager gm = findObj.GetComponent<GameManager>();

            // 3. Cộng điểm và in ra Console để kiểm tra
            gm.score += 10;
            Debug.Log("Điểm hiện tại lấy từ GameManager: " + gm.score);
        }
        else
        {
            Debug.LogError("Không tìm thấy GameManager! Hãy chạy từ Scene Menu nhé.");
        }
    }
}