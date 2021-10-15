using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandManager : MonoBehaviour
{
    private InputField command;

    void Start()
    {
        command = this.gameObject.GetComponent<InputField>();
        command.Select();
    }
    // void OnEnable()
    // {
    //     if(command == null) Debug.Log("ぬるです");
    //     else {command.Select();
    //     Debug.Log("えんねいぶるです");}
    // }

    public void GetText()
    {
        switch (command.text)
        {
            case "a" :
                cheet.Broken();
                Debug.Log("OMG");
                break;
            default :
                break;
        }
        command.text = null;
    }
}
