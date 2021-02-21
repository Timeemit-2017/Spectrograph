using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BasicMessage : MonoBehaviour
{
    /*
     * 这个脚本是让[曲目信息]中的ui上的信息赋值到全局变量的
     */
    public string target;
    private InputField inputField;
    private static Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        textComponent = inputField.textComponent;
    }

    private void Update()
    {
        SendData(target);
    }

    static public void SendData(string target)
    {
        PublicVars.SetVar(target, textComponent.text);
    }
}
