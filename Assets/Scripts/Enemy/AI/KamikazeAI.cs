using UnityEngine;

public class KamikazeAI : Enemy
{
    public int Damage;

    void Start()
    {
        _EnginePower = 11;
        health = 10;
        _RotationSpeed = 3f * Time.deltaTime;
    }
    void FixedUpdate()
    {
        AddForce();
        Damage = (int)health;
    }
}