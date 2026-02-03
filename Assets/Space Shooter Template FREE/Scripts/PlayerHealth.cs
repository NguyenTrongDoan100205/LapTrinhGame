using UnityEngine;

public class PlayerHealth : Health // [cite: 190]
{
    protected override void Die() // [cite: 192]
    {
        base.Die(); // [cite: 194]
        Debug.Log("Player died"); // [cite: 195]
    }
}