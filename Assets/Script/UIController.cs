using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject CommandLine;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)){
           Code.Active_TF(CommandLine);
        }
    }
}