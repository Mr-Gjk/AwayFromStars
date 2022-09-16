using UnityEngine;

public class DamageTaker : MonoBehaviour
{
    [SerializeField] int health = 100;
    void OnTriggerEnter2D (Collider2D collision)
    {
        Projectile newP = collision.gameObject.GetComponent<Projectile>();
        EnemyTakeDamage(newP.Damage);
        Destroy(collision.gameObject);
    }
    void EnemyTakeDamage (int hitPoint)
    {
        health -= hitPoint;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
