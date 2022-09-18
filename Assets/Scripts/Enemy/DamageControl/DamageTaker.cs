using UnityEngine;

public class DamageTaker : Enemy
{
    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag("PlayerProjectile"))
        {
            Projectile newP = collision.gameObject.GetComponent<Projectile>();
            TakeDamage(newP.Damage);
            Destroy(collision.gameObject);
        }
    }
    void TakeDamage (int hitPoint)
    {
        health -= hitPoint;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
