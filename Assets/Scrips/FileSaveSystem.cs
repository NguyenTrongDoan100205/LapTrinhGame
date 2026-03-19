using UnityEngine;
using System.IO; // THƯ VIỆN BẮT BUỘC để làm việc với File

public class FileSaveSystem : MonoBehaviour
{
    private string savePath;

    void Awake()
    {
        // Thiết lập đường dẫn file: C:/Users/.../AppData/LocalLow/YourCompany/SaveData.json
        savePath = Application.persistentDataPath + "/player_save.json";
        Debug.Log("Đường dẫn file lưu: " + savePath);
    }

    // Hàm LƯU dữ liệu
    public void SaveGame()
    {
        PlayerData data = new PlayerData(); // Dùng lại Class ở Lab 4
        data.playerName = "Đoàn Hiền";
        data.level = 99;

        // 1. Chuyển Object thành chuỗi JSON
        string json = JsonUtility.ToJson(data);

        // 2. Ghi chuỗi JSON đó vào file vật lý trên ổ cứng
        File.WriteAllText(savePath, json);

        Debug.Log("Đã lưu file thành công tại: " + savePath);
    }

    // Hàm ĐỌC dữ liệu
    public void LoadGame()
    {
        // Kiểm tra xem file có tồn tại không trước khi đọc
        if (File.Exists(savePath))
        {
            // 1. Đọc toàn bộ nội dung file thành chuỗi
            string json = File.ReadAllText(savePath);

            // 2. Chuyển chuỗi JSON ngược lại thành Object
            PlayerData loadedData = JsonUtility.FromJson<PlayerData>(json);

            Debug.Log("Đã load! Tên: " + loadedData.playerName + " - Level: " + loadedData.level);
        }
        else
        {
            Debug.LogWarning("Không tìm thấy file lưu!");
        }
    }
}