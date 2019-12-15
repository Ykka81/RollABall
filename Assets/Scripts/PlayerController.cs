using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jump;
    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);

        if (Input.GetKeyDown("space") && GetComponent<Rigidbody>().transform.position.y <= 1.0f)
        {
            Vector3 jump = new Vector3(0.0f, 200.0f, 0.0f);

            rb.AddForce(jump);
        }
    }

}
