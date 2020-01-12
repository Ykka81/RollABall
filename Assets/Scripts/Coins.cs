using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    public Material myMaterial;

    public void Start()
    {
        Material myMaterial = Resources.Load("Material/coins", typeof(Material)) as Material;
    }

    void Update()
    {
        GetComponent<MeshRenderer>().material = myMaterial;
    }
}
