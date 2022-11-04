using UnityEngine;

public partial class Enemy : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag("PlayerProjectile"))
        {
            Projectile newP = collision.gameObject.GetComponent<Projectile>();
            TakeDamage(Random.Range(newP.Damage*0.8f , newP.Damage * 1.2f));
            Destroy(collision.gameObject);
        }
    }
    void TakeDamage (float hitPoint)
    {
        health -= (int)hitPoint;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
