using UnityEngine;
using System.Collections;

public class Coin1 : Coins
{


    public void FixedUpdate()
    {
        Material myMaterial = Resources.Load("Material/Bcoin", typeof(Material)) as Material;
    }

}
