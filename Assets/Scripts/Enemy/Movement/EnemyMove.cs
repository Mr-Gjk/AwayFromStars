using UnityEngine;

public partial class Enemy : MonoBehaviour
{
    private float _rotationSpeed;

    public float _RotationSpeed
    {
        get { return _rotationSpeed; }
        set { _rotationSpeed = value; }
    }
    public void Rotate()
    {
        Vector2 new_rotation = _Player.transform.position - gameObject.transform.position;
        gameObject.transform.up = Vector2.MoveTowards(transform.up , new_rotation, _RotationSpeed);
    }
    public void AddForce()
    {
        Rotate();
        transform.Translate(Vector2.up * _enginePower* Time.deltaTime);
    }
}