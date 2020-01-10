using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour
{
    public Text TimerText;
    private float startTime;
    private bool finnished = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update() 
    {
        if (finnished)
                return;

        float t = Time.time - startTime;
        //int moi = 1;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        //TimerText.text = minutes + ":" + seconds;
        TimerText.text = seconds;
    }

    public void Finnish()
    {
        finnished = true;
        TimerText.color = Color.yellow;
    }
}
