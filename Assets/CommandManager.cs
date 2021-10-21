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

    private int num;
    public void GetText()
    {
        string[] array = command.text.Split(' ');
        // コマンド処理
        switch (array[0])
        {
            case "fps" :
                cheet.fps();
                break;

            case "tps" :
                cheet.tps();
                break;

            case "broken" :
                cheet.broken();
                Debug.Log("OMG");
                break;

            case "boost" :
                cheet.boost(float.Parse(array[1]));
                break;

            default :
                break;
        }
        command.text = null;
    }
}
