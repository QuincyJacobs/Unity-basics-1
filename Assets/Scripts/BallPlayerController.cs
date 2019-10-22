using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        Debug.Log(rigidBody.velocity);

        rigidBody.AddForce(new Vector3(-moveVertical, 0.0f, moveHorizontal) * speed);
        if(rigidBody.velocity.x > 10)
        {
            rigidBody.velocity = new Vector3(10, rigidBody.velocity.y, rigidBody.velocity.z);
        }
        else if(rigidBody.velocity.x < -10)
        {
            rigidBody.velocity = new Vector3(-10, rigidBody.velocity.y, rigidBody.velocity.z);
        }
        if (rigidBody.velocity.z > 10)
        {
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, 10);
        }
        else if (rigidBody.velocity.z < -10)
        {
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, -10);
        }
        Debug.Log(rigidBody.velocity);
    }
}
