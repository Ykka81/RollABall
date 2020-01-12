using UnityEngine;
using System.Collections;

public class Coin4 : Coins
{

    public void FixedUpdate()
    {
        Material myMaterial = Resources.Load("Material/Scoin", typeof(Material)) as Material;
    }
}