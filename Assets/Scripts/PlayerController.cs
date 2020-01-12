using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpSpeed = 5f;
    public bool isGrounded;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 2, 0) * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }
    }
}

    //    if (Input.GetKeyDown("space") && GetComponent<Rigidbody>().transform.position.y <= 100.0f)
    //    {
    //        Vector3 jump = new Vector3(0.0f, 200.0f, 0.0f);

    //        rb.AddForce(jump);
    //    }
    //}
