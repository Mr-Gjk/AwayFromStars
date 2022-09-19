using UnityEngine;

public partial class Player : MonoBehaviour
{
    void Camera()
    {

        Vector2 forceVector = _Player.transform.position - _Camera.transform.position;
        _CameraRigidbody.velocity = forceVector * 3;
    }
}
