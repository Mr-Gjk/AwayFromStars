using UnityEngine;

public partial class Player : MonoBehaviour
{
    //All the necessary components for player movement and the visual effect of the running engine
    private static GameObject _player;
    private static Rigidbody2D _playerRigidbody;
    private static FixedJoystick _joystick;
    private static ParticleSystem _particles;
    private static AudioSource _audio;
    //Components of the camera, they are need to make possible move camera to player
    private static GameObject _camera;
    private static Rigidbody2D _cameraRigidbody;
    //Data of the engine power (need for add force to ship) and the engine fire (need for setting the fire length after the player ship)
    public static float _enginePower = 100000;
    public static float _engineFire = 0.04f;

    int health = 50;
    int shield = 50;
    float _maxHealth;
    float _maxShield;

    public GameObject _Player
    {
        get { return _player; }
        set { _player = value; }
    }
    public Rigidbody2D _PlayerRigidbody
    {
        get { return _playerRigidbody; }
        set { _playerRigidbody = value; }
    }
    public FixedJoystick _Joystick
    {
        get { return _joystick; }
        set { _joystick = value; }
    }
    public ParticleSystem _Particles
    {
        get { return _particles; }
        set { _particles = value; }
    }

    public GameObject _Camera
    {
        get { return _camera; }
        set { _camera = value; }
    }
    public Rigidbody2D _CameraRigidbody
    {
        get { return _cameraRigidbody; }
        set { _cameraRigidbody = value; }
    }
    public AudioSource _Audio
    {
        get { return _audio; }
        set { _audio = value; }
    }

    public float _MaxHealth
    {
        get { return _maxHealth; }
        set { _maxHealth = value; }
    }
    public float _MaxShield
    {
        get { return _maxShield; }
        set { _maxShield = value; }
    }

    void Awake()
    {
        _Player = gameObject;
        _PlayerRigidbody = _Player.GetComponent<Rigidbody2D>();
        _Camera = GameObject.Find("MainCamera");
        _CameraRigidbody = _Camera.GetComponent<Rigidbody2D>();
        _Particles = _Player.GetComponent<ParticleSystem>();
        _Joystick = Canvas.FindObjectOfType<FixedJoystick>();
        _Audio = GetComponent<AudioSource>();
        ChunkLoader();
        _MaxHealth = health;
        _MaxShield = shield;
        isInventoryOpen = Inventory.active;
        OpenInventory();
    }

    void FixedUpdate()
    {
        CharacterMove();
        Camera();
    }
}