using UnityEngine;

public class TurretAI : Enemy
{
    private void Start()
    {
        health = 500;
    }
    void FixedUpdate()
    {
        _RotationSpeed = 1f * Time.deltaTime;
        Rotate();
    }
}
