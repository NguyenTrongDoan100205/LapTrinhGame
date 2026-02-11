using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Dòng này cực kỳ quan trọng để hết lỗi "instance" trong Unity
    public static PlayerShooting instance;

    public GameObject bulletPrefabs;
    public float shootingInterval;
    public Vector3 bulletOffset;
    private float lastBulletTime;

    // Các biến này để hết lỗi cho các script Bonus
    public int weaponPower = 1;
    public int maxweaponPower = 4;

    private void Awake()
    {
        // Khởi tạo instance
        if (instance == null) instance = this;
    }

    void Update()
    {
        // Kiểm tra nếu nhấn giữ chuột trái thì gọi hàm xử lý bắn
        if (Input.GetMouseButton(0))
        {
            UpdateFiring();
        }
    }

    private void UpdateFiring()
    {
        // Kiểm tra giãn cách thời gian giữa các viên đạn
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        if (bulletPrefabs != null)
        {
            // Khởi tạo đạn tại vị trí máy bay + độ lệch Offset
            Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
        }
    }
}