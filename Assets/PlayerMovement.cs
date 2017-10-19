using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody playerBody;
    public float forwardForce = 1000f;
    public float sideForce = 1000f;
    public bool moveLeft = false;
    public bool moveRight = false;

    void Update()
    {
        if(Input.GetKey("a"))
        {
            moveLeft = true;
        }

        if (Input.GetKey("d"))
        {
            moveRight = true;
        }
    }

    // Updating Physics
    void FixedUpdate () {

        playerBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(moveLeft == true)
        {
            playerBody.AddForce(-sideForce * Time.deltaTime, 0, 0);
            moveLeft = false;
        }

        if (moveRight == true)
        {
            playerBody.AddForce(sideForce * Time.deltaTime, 0, 0);
            moveRight = false;
        }
    }
}
