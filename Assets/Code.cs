using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class Code
{
    public static void Active_ON(GameObject obj){
        obj.SetActive(true);
    }
    public static void Active_OFF(GameObject obj){
        obj.SetActive(false);
    }
    public static void Active_TF(GameObject obj){
        if(obj.activeSelf) obj.SetActive(false);
        else obj.SetActive(true);
    }
    public static void DestroyAll(GameObject[] obj)
    {
        foreach (GameObject o in obj)
        {
            Object.Destroy(o);
        }
    }
    public static void DL_T(Text text)
    {
        Debug.Log(text.text);
    }
}