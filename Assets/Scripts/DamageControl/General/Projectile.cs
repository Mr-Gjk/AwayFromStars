using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int Damage = 20;
    void Awake()
    {
        Destroy(gameObject, 5);
    }
}
