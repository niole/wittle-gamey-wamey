using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    public Vector3 offset = new Vector3(0, 0, -8);

    // Update is called once per frame
    void Update()
    {

        // feed player position to the camera
        // to make it follow the player, without spinning around with the player
        transform.position = player.position + offset;
        Debug.Log(player.position);
    }
}
