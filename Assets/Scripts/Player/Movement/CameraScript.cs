using UnityEngine;

public partial class CameraScript : Player
{
    void FixedUpdate()
    {

        Vector2 forceVector = _Player.transform.position - _Camera.transform.position;
        _CameraRigidbody.velocity = forceVector * 3;
    }
}
