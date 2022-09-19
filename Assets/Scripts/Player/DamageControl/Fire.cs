using UnityEngine;

public partial class Player : MonoBehaviour
{

    [SerializeField] private GameObject _projectile;
    private float _projectileSpeed = 25;

    [SerializeField] private AudioClip din;
    public void OnClick()
    {
        GameObject projectile =  Instantiate(_projectile);
        Rigidbody2D rigidbody = projectile.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D;

        projectile.transform.rotation = _Player.transform.rotation;
        projectile.transform.position = _Player.transform.position;

        _Audio.PlayOneShot(din);
        rigidbody.velocity = GetVelocity();
        
    }

    //Function "GetVelocity" Create a new Vector2 and take from player his velocity to create right direction of travel
    Vector2 GetVelocity()
    {
        Vector2 finalVelocity;
        Vector2 playerVelocity = _PlayerRigidbody.velocity;
        float velocityX = playerVelocity.x;
        float velocityY = playerVelocity.y;

        //Check is player have speed, if no, we know right direction (literally to the right)
        if (playerVelocity.magnitude != 0)
        {
            // We create a new variable "speedRatio" to set the vector of speed in x & y ratio
            float speedRatio = Mathf.Abs(playerVelocity.x) + Mathf.Abs(playerVelocity.y);
            velocityX = playerVelocity.x * _projectileSpeed / speedRatio;
            velocityY = playerVelocity.y * _projectileSpeed / speedRatio;
        }
        else
        {
            velocityX = _projectileSpeed;
            velocityY = 0;
        }
        finalVelocity = new Vector2(velocityX, velocityY);
        return finalVelocity;
    }
}
