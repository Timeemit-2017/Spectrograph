using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVars : MonoBehaviour
{
    /*
     * 这个脚本就是一个储存全局变量的
     * 歌曲的基本信息都会存储在这里
     * 调用的时候用PublicVars.varName就行了
     * 绑在了一个叫做"信息"的空对象上了
     */
    private static Dictionary<string, string> varDict = new Dictionary<string, string>();
    static public string songName = "Untitled"; //歌曲名称
    static public string songAuthor = "Unknown"; //歌曲的作者
    static public string noteDesigner = "Unknown"; //谱师
    static public string bpm = "Unknown"; //歌曲的bpm *注意是str不是int
    static public string difficulty = "Unknown"; //溯式度（难度）注意是str不是int
    void Start()
    {   
        /*
         * 为什么不直接赋值？
         * 因为我写到一半发现字典更合适懒得改了（
         */
        varDict.Add("songName", songName);
        varDict.Add("songAuthor", songAuthor);
        varDict.Add("noteDesigner", songName);
        varDict.Add("bpm", bpm);
        varDict.Add("difficulty", songName);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            //Debug.Log(songName + "," + songAuthor + "," + noteDesigner + "," + bpm + "," + difficulty);
            Debug.Log(varDict["songName"]);
        }
    }

    static public void SetVar(string name, string value)
    {   
        varDict[name] = value;
    }    
}
