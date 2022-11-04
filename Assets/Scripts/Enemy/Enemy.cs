using UnityEngine;

public partial class Enemy : MonoBehaviour
{
    private Player _player;
    private GameObject _enemy;
    private Rigidbody2D _rigidbody;
    public int health;
    private float _enginePower;

    public GameObject _Enemy
    {
        get { return _enemy; }
        set { _enemy = value; }
    }
    public Player _Player
    {
        get { return _player; }
        set { _player = value; }
    }
    public Rigidbody2D _Rigidbody
    {
        get { return _rigidbody; }
        set { _rigidbody = value; }
    }
    public float _EnginePower
    {
        get { return _enginePower; }
        set { _enginePower = value; }
    }

    void Awake()
    {
        _Enemy = gameObject;
        _Rigidbody = gameObject.GetComponent<Rigidbody2D>();
        _Player = GameObject.Find("PlayerShip").GetComponent<Player>();
    }
}
