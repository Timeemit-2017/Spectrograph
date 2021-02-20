using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeDisplay : MonoBehaviour
{
    private string timeText;
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText = audioControl.musicTime.ToString("F2");
        text.text = timeText;
    }
}
