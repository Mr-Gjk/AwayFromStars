using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _cam;
    [SerializeField] private Rigidbody2D _rigidbody2D;


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 test = _player.transform.position - _cam.transform.position;
        _rigidbody2D.velocity = test*3;
    }
}
