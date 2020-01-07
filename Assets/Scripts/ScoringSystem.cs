using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{

    public GameObject scoreText;
    public int theScore;

    void OnTriggerEnter(Collider other)
    {
        theScore += 50;
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
        Destroy(gameObject);
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
