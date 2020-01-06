using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetect : MonoBehaviour
{
    Vector3 checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <-60)
        {
            transform.position = checkpoint;
        }
    }
}
