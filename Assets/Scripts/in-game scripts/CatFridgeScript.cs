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
    }

    private void dead()
    {
        if (healthPoints <= 0)
        {
            Object.Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("HitTriggerZone"))
        {
            TakeDamage(10);
            if (healthPoints <= 0)
            {
                dead();
            }
        }
    }

}
