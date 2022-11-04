using UnityEngine;
using UnityEngine.UI;

public partial class Player : MonoBehaviour
{
    [SerializeField] private Image _hp;
    [SerializeField] private Image _shield;
    float _fillHealth = 1f;
    float _fillShield = 1f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyProjectile"))
        {
            KamikazeAI newP = collision.gameObject.GetComponent<KamikazeAI>();
            TakeDamage(Random.Range(newP.Damage * 0.9f, newP.Damage * 1.1f));
            Debug.Log("Pew");
            Destroy(collision.gameObject);
        }
    }
    void TakeDamage(float hitPoint)
    {
        if (shield > 0)
        {
            shield -= (int)hitPoint;
            _fillShield = shield / _maxShield;
            _shield.fillAmount = _fillShield;
        }
        else
        {
            health -= (int)hitPoint;
            _fillHealth = health / _maxHealth;
            _hp.fillAmount = _fillHealth;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}