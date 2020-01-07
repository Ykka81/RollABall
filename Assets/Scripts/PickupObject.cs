using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupObject : MonoBehaviour
{
    public static int theScore;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            theScore += 1;
            print("KERÄTYT KOLIKOT " + theScore + "/6");
            Destroy(gameObject);
        }
        if(theScore == 6)
        {
            print("Keräsit kaikki kolikot!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
