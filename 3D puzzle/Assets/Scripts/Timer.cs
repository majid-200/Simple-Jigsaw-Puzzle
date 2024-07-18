using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer = 0;
    public bool active;

    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        if (active)
        {

            timer = Time.deltaTime + timer;
            string minutes = ((int)timer / 60).ToString();
            string seconds = (timer % 60).ToString("f0");
            if ((minutes.Length == 1) && (seconds.Length == 1))
            {
                timerText.text = "0" + minutes + ":0" + seconds;
            }
            else if ((seconds.Length > 1) && (minutes.Length == 1))
            {
                timerText.text = "0" + minutes + ":" + seconds;
            }
            else if ((minutes.Length > 1) && (seconds.Length == 1))
            {
                timerText.text = minutes + ":0" + seconds;
            }
            else
            {
                timerText.text = minutes + ":" + seconds;
            }
        }
        
    }
}
