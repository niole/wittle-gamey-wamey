using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    // is called whenever the object that this component applies to collides with something
    // as long as that object has a rigidbody and a collider
    void OnCollisionEnter (Collision collisionDetails)
    {

        if (collisionDetails.collider.tag == "Obstacle")
        {
            Debug.Log("Hit and Obstacle");
            movement.enabled = false;
        }
    }
}
