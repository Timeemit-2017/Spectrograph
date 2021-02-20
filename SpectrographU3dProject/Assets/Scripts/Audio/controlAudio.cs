using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAudio : MonoBehaviour
{
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audioControl.SetTime(speed * Input.GetAxis("Horizontal"));
    }
}
