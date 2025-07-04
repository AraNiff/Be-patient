using System.Collections.Generic;
using UnityEngine;

public class AttacjScript : MonoBehaviour
{
    public PolygonCollider2D AttackCollider;
    public int DamageAount = 10;
    void Start()
    {
        AttackCollider = GetComponentInChildren<PolygonCollider2D>();
        AttackCollider.enabled = false;
        if (AttackCollider != null)
        {
            Debug.Log("��������� ������!");
        }
    }

    public void Attack(int DamageAmount)
    {
        AttackCollider.enabled = true;
        List<Collider2D> hitResults = new List<Collider2D>();
        ContactPoint2D[] contacts = new ContactPoint2D[10]; // ������ ��� �������� ���������

        int hitCount = AttackCollider.Overlap(new ContactFilter2D(), hitResults);
        for (int i = 0; i < hitCount; i++)
        {
            // ���������, �������� �� ���� ������ ������, � ��������� � ���� ����
            if (hitResults[i].CompareTag("Enemy"))
            {
                hitResults[i].GetComponent<CatFridgeScript>().TakeDamage(DamageAount);
            }
        }
        AttackCollider.enabled = false;
    }
}
