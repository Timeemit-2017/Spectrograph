using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioControl : MonoBehaviour
{
    public AudioClip music;
    static public AudioSource audioSource;
    private bool endFlag;
    static public bool isPause;
    static public float musicLength;
    static public float musicTime;
    
    

    // Start is called before the first frame update
    void Start()
    {   
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = music;
        isPause = true;
        musicLength = music.length;
        endFlag = false;
    }

    // Update is called once per frame
    void Update()
    {   
        musicTime = audioSource.time;
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            if (isPause == true)
            {   
                /*
                if (endFlag)
                {
                    audioSource.time = 0.0f;
                    endFlag = false;
                }
                */
                audioSource.Play();
                isPause = false;
            }
            else
            {
                audioSource.Pause();
                isPause = true;
            }
        }

        /*
         * 在歌曲结束的时候停留在末尾而不是自动回到开头（）
         * 总是有奇奇怪怪的bug，有的时候这个效果出现不了，有想法的老哥可以帮我修一下
        if (musicTime >= musicLength - 0.01 && endFlag != true)
        {
            audioSource.Pause();
            isPause = true;
            endFlag = true;
        }
        */
    }

    static public bool SetTime(float timeTarget)
    {
        if (isPause)
        {
            float timeGoingToPlus = audioSource.time + timeTarget;
            if (timeGoingToPlus < 0.0f)
            {
                timeGoingToPlus = 0;
            }
            else if (timeGoingToPlus > musicLength)
            {
                timeGoingToPlus = musicLength;
            }
            audioSource.time = timeGoingToPlus;
            return true;
        }
        else
        {
            //因为没有在暂停状态，所以设置时间失败
            return false;
        }
    }
}
