using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public int damage;

    public AudioSource audioSource;   // 👈 thêm
    public AudioClip shootClip;       // 👈 thêm

    void Start()
    {
        audioSource.PlayOneShot(shootClip); // 👈 phát tiếng khi sinh ra
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet hit: " + collision.name);

        if (collision.CompareTag("Player"))
            return;

        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }


    void Update()
    {
        transform.Translate(Vector2.up * flySpeed * Time.deltaTime);
    }
}
