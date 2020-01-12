using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupObject : MonoBehaviour
{
    private static int theScore;
    public Text CoinsText;
    public Text PeriText;

    public int Jemmassa
    {
        set
        {
            theScore = value;
        }
        get
        {
            return theScore;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            theScore += 1;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        CoinsText.color = Color.red;
        CoinsText.text = ("KERÄTYT KOLIKOT " + theScore + "/6");
    }
}
