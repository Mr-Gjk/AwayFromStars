using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player _player;
    private GameObject _enemy;
    private Rigidbody2D _rigidbody;
    public static int health = 100;

    public GameObject _Enemy
    {
        get { return _enemy; }
        set { _enemy = value; }
    }
    public Rigidbody2D _Rigidbody
    {
        get { return _rigidbody; }
        set { _rigidbody = value; }
    }

}
