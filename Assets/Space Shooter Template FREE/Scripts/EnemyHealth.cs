using UnityEngine;

public class EnemyHealth : Health // Kế thừa từ Health [cite: 199]
{
    // KHÔNG khai báo lại explosionPrefab ở đây

    protected override void Die() // [cite: 203]
    {
        base.Die(); // [cite: 205]
        Debug.Log("Enemy died"); // [cite: 206]
    }
}