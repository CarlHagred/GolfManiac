using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Shoot ball;
    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Stroke: " + ball.counter.ToString();
    }
}
