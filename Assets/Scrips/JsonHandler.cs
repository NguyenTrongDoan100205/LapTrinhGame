using UnityEngine;

public class JsonHandler : MonoBehaviour
{
    void Start()
    {
        // 1. TẠO DỮ LIỆU MẪU
        PlayerData myData = new PlayerData();
        myData.playerName = "Đoàn Hiền";
        myData.level = 10;
        myData.health = 95.5f;

        // 2. CHUYỂN ĐỔI SANG JSON (Serialization)
        // Biến Object thành chuỗi String
        string json = JsonUtility.ToJson(myData);

        Debug.Log("Chuỗi JSON thu được: " + json);
        // Kết quả sẽ dạng: {"playerName":"Đoàn Hiền","level":10,"health":95.5}

        // 3. LƯU CHUỖI JSON VÀO MÁY (Kết hợp PlayerPrefs để lưu nhanh)
        PlayerPrefs.SetString("SaveGame", json);

        // 4. ĐỌC DỮ LIỆU TỪ JSON (Deserialization)
        string loadedJson = PlayerPrefs.GetString("SaveGame");
        PlayerData loadedData = JsonUtility.FromJson<PlayerData>(loadedJson);

        Debug.Log("Tên người chơi sau khi load: " + loadedData.playerName);
    }
}