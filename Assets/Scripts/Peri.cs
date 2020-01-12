using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peri : PickupObject
{
    private bool see;

    void Update()
    {
        see = true;

        if (see == true)
        {         
            if (Jemmassa == 6)
            {
                PeriText.color = Color.blue;
                PeriText.text = ("KERÄSIT KAIKKI KOLIKOT!");
            }
        }
    }
}
