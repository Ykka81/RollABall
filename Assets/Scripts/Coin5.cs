using UnityEngine;
using System.Collections;

public class Coin5 : Coins
{
    public void FixedUpdate()
    {
        Material myMaterial = Resources.Load("Material/Gcoin", typeof(Material)) as Material;
    }
}