using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]

    public class CharacterMove : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private Rigidbody2D _playerRigidbody2D;
        [SerializeField] private FixedJoystick _joystick;
        [SerializeField] private ParticleSystem _particle;
        [SerializeField] private float _enginePower;
        [SerializeField] private float _engineFire;

        // Update is called once per frame
        void FixedUpdate()
        {
            _playerRigidbody2D.AddForce(Force());
            _particle.startLifetime = _engineFire * _playerRigidbody2D.velocity.magnitude;
            _player.transform.rotation = Quaternion.Euler(0, 0, DirectionZ());
        }

        float DirectionZ()
        {
            float x = _playerRigidbody2D.velocity.x;
            float y = _playerRigidbody2D.velocity.y;
            float angle;
            if (x > 0)
            {
                angle = Mathf.Atan(y / x) * 180 / Mathf.PI;
            }
            else
            {
                angle = 180 + (Mathf.Atan(y / x) * 180 / Mathf.PI);
            }
            return angle;
        }
    Vector2 Force()
    {
        float horizontal = _joystick.Horizontal * _enginePower / _playerRigidbody2D.mass;
        float vertical = _joystick.Vertical * _enginePower / _playerRigidbody2D.mass;
        return new Vector2(horizontal,vertical) -_playerRigidbody2D.velocity * _playerRigidbody2D.mass;
    }
    }

