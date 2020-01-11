using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupObject : MonoBehaviour
{
    public static int theScore;
    public Text CoinsText;
    public Text PeriText;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            theScore += 1;
            Destroy(gameObject);
        }
    }

    void Start()
    {
    }

    void Update()
    {
        CoinsText.color = Color.red;
        CoinsText.text = ("KERÄTYT KOLIKOT " + theScore + "/6");
    }
}
