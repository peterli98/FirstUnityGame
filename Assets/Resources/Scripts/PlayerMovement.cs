using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody playerBody;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public float upForce = 500f;
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
			playerBody.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveLeft = false;
        }

        if(moveRight == true)
        {
			playerBody.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveRight = false;
        }

        if(jump == true)
        {
            playerBody.AddForce(transform.up * upForce);
            jump = false;
        }

		if (playerBody.position.y < -1) 
		{
			FindObjectOfType<GameManager> ().EndGame ();
		}
    }
}
