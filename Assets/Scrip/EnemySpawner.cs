using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Kéo Prefab Enemy vào ô này ở Inspector
    public GameObject enemyPrefab;

    void Update()
    {
        // Kiểm tra nếu người dùng nhấn phím Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Tạo ra một bản sao của Prefab tại vị trí của Spawner
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}