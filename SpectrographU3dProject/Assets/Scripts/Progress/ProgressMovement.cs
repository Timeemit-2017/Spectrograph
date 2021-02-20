using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressMovement : MonoBehaviour
{
    //public Sprite progress;
    private static float origin = -4.722f;
    private static float end = 10.0835f;
    private float length = end - origin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ratio = audioControl.musicTime / audioControl.musicLength;
        float thisX = origin + length * ratio;
        if (thisX > 10.0835f)
        {
            thisX = 10.0835f;
        }
        Vector3 thisPos = new Vector3(thisX, 0.9566f, 0.0f);
        transform.position = thisPos;
    }
}
