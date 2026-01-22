using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Dòng này giúp xóa lỗi đỏ "instance" trong Safe Mode
    public static PlayerShooting instance;

    public GameObject bulletPrefabs; // Sẽ hiện là "Bullet Prefabs"
    public float shootingInterval;  // Sẽ hiện là "Shooting Interval"
    private float lastBulletTime;

    // Các biến này giúp xóa lỗi đỏ "weaponPower" trong script Bonus
    public int weaponPower = 1;
    public int maxweaponPower = 4;

    private void Awake()
    {
        // Khởi tạo để các script khác có thể gọi được
        if (instance == null) instance = this;
    }

    void Update()
    {
        // Bắn tự động khi giữ chuột trái
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        if (bulletPrefabs != null)
        {
            Instantiate(bulletPrefabs, transform.position, transform.rotation);
        }
    }
}