using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData enemyData; // Reference to the EnemyData ScriptableObject

    void Start()
    {
        // You can initialize or set values here if needed
    }

    public void OnDeath()
    {
        // Assuming onDeath is called when the enemy dies
        enemyData.Die(gameObject); // Pass the current GameObject to the Die method
    }
}
