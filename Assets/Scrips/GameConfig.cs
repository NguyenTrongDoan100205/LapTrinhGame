using UnityEngine;

// Dòng này giúp bạn tạo file dữ liệu từ menu chuột phải của Unity
[CreateAssetMenu(fileName = "NewGameConfig", menuName = "Configs/PlayerConfig")]
public class GameConfig : ScriptableObject
{
    public string itemName;
    public float moveSpeed;
    public int maxHealth;
    public Color themeColor;
}