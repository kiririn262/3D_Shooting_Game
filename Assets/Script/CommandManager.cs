using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandManager : MonoBehaviour
{
    private InputField command;
    [SerializeField]
    private GameObject _Frog;

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

    //private int num;
    public void GetText()
    {
        string[] array = command.text.Split(' ');
        // コマンド処理
        switch (array[0])
        {
            case "fullauto":
                cheet.FullAuto();
                #if UNITY_EDITOR
                    Debug.Log("FullAuto:" + cheet._fullauto);
                #endif
                break;

            case "fps" :
                #if UNITY_EDITOR
                    Debug.Log("FPS mode");
                #endif
                cheet.fps();
                break;

            case "tps" :
                #if UNITY_EDITOR
                    Debug.Log("TPS mode");
                #endif
                cheet.tps();
                break;

            case "homing" :
                cheet.Homing();
                #if UNITY_EDITOR
                    Debug.Log("homing:"+ cheet._homing);
                #endif
                break;

            case "boost" :
                #if UNITY_EDITOR
                    Debug.Log("boost:"+ float.Parse(array[1]));
                #endif
                cheet.boost(float.Parse(array[1]));
                break;

            case "frog":
                cheet.Frog(_Frog);
                #if UNITY_EDITOR
                    Debug.Log("frog:"+ cheet._frog);
                #endif
                break;

            default :
                break;
        }
        command.text = null;
    }
}
