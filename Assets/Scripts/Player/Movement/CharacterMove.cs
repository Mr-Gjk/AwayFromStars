using UnityEngine;

public partial class Player : MonoBehaviour
{

    void CharacterMove()
        {
            _PlayerRigidbody.AddForce(Force());
            _Particles.startLifetime = _engineFire * _PlayerRigidbody.velocity.magnitude;
            _Player.transform.rotation = Quaternion.Euler(0, 0, DirectionZ());
        }

        float DirectionZ()
        {
            float x = _PlayerRigidbody.velocity.x;
            float y = _PlayerRigidbody.velocity.y;
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
            float horizontal = _Joystick.Horizontal * _enginePower / _PlayerRigidbody.mass;
            float vertical = _Joystick.Vertical * _enginePower / _PlayerRigidbody.mass;
            return new Vector2(horizontal,vertical) -_PlayerRigidbody.velocity * _PlayerRigidbody.mass;
        }
    }

