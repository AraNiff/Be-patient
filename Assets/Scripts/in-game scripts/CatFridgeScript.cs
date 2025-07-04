using UnityEngine;
using UnityEngine.UI;

public class CatFridgeScript : MonoBehaviour
{
    public Text nameText;

    public int healthPoints;
    public int attack;

    public void Start()
    {
        healthPoints = 100;
        attack = 10;
    }
    public void TakeDamage(int damage)
    {
        healthPoints -= damage;
        Debug.Log("Enemy took damage: " + damage + ". Remaining health: " + healthPoints);
        if (healthPoints <= 0)
        {
            Die();
            Debug.Log("Enemy died");
        }
    }

    private void Die()
    {
        Object.Destroy(gameObject);
    }
}
