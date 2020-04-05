using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    public Text scoreView;

    private int score = 0;

    // is called whenever the object that this component applies to collides with something
    // as long as that object has a rigidbody and a collider
    void OnCollisionEnter (Collision collisionDetails)
    {

        if (collisionDetails.collider.tag == "Obstacle")
        {
            score += 1;
            Debug.Log(scoreView);
            scoreView.text = score.ToString();
//            movement.enabled = false;
        }
    }
}
