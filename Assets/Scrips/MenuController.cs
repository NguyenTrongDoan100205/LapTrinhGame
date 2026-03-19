using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // 1. PHẢI CÓ DÒNG NÀY ĐỂ DÙNG TEXTMESHPRO

public class MenuController : MonoBehaviour
{
    // 2. ĐỔI 'InputField' THÀNH 'TMP_InputField'
    public TMP_InputField nameInput;

    public void StartGame()
    {
        // Kiểm tra xem người dùng đã nhập tên chưa
        if (nameInput != null && !string.IsNullOrEmpty(nameInput.text))
        {
            DataManager.PlayerName = nameInput.text;
            SceneManager.LoadScene("Game");
        }
        else
        {
            Debug.Log("Vui lòng nhập tên!");
        }
    }
}