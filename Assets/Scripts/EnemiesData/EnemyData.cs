using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "Enemies/Enemy")]
public class EnemyData : ScriptableObject
{
    public string enemyName;       // Name of the enemy
    public float health;           // Health points
    public float damage;           // Damage it deals
    public float speed;            // Movement speed

    public void Die(GameObject enemy)
    {
        Destroy(enemy); // Destroy the GameObject when it dies
    }
}