using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // name things crappily, just like in tutorial so don't get lost

    public Rigidbody rb;

    // this variable will show up as an input box in the Player Movement (Script) component
    // in editor, with default value: 2000
    public float forwardForce = 1000f;

    public float sideForce = 750f;

    private bool isD = false;
    private bool isW = false;
    private bool isA = false;
    private bool isS = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("you have started");
    }

    // Update is called once per frame
    // frequency depends on framerate, which varies with time and per computer
    // use fixedupdate when changing physics, as per unity requirement
    // changes will be smoother
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        applyUserInput();
    }

    // check for user input in the Update method, works nicer
    void Update()
    {
        isD = Input.GetKey("d");
        isA = Input.GetKey("a");
        isW = Input.GetKey("w");
        isS = Input.GetKey("s");
    }

    void applyUserInput()
    {
        if (isD)
        {
            rb.AddForce(Step(), 0, 0);
        }
        if (isA)
        {
            rb.AddForce(-Step(), 0, 0);
        }
        if (isW)
        {
            rb.AddForce(0, 0, Step());
        }
        if (isS)
        {
            rb.AddForce(0, 0, -Step());
        }
    }


    float Step()
    {
        return sideForce * Time.deltaTime;
    }
}
