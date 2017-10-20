using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody playerBody;
    public float forwardForce = 1000f;
    public float sideForce = 750f;
    public float upForce = 250f;
    public bool moveLeft = false;
    public bool moveRight = false;
    public bool jump = false;

    void Update()
    {
        if(Input.GetKey("a"))
        {
            moveLeft = true;
        }

        if(Input.GetKey("d"))
        {
            moveRight = true;
        }

        if(Input.GetKeyDown("space"))
        {
            Debug.Log("i jumped");
            jump = true;
        }
    }

    // Updating Physics
    void FixedUpdate() {

        playerBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(moveLeft == true)
        {
            playerBody.AddForce(-sideForce * Time.deltaTime, 0, 0);
            moveLeft = false;
        }

        if(moveRight == true)
        {
            playerBody.AddForce(sideForce * Time.deltaTime, 0, 0);
            moveRight = false;
        }

        if(jump == true)
        {
            playerBody.AddForce(transform.up * upForce);
            jump = false;
        }
    }
}
