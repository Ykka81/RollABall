using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peri : PickupObject
{
    void Start()
    {
    }
    void Update()
    {
        if (theScore == 6)
        {
            PeriText.color = Color.blue;
            PeriText.text = ("KERÄSIT KAIKKI KOLIKOT!");
        }
    }
}
