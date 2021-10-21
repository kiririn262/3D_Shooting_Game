using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class Code
{
    public static void LoadtoScene(int num)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(num);
    }
    public static void LoadtoScene(string str)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(str);
    }
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

    public static float Col_Sin(float radius, float speed)
    {
        float num;
        num = radius * Mathf.Sin(Time.time * speed);
        return num;
    }

    public static float Col_Cos(float radius, float speed)
    {
        float num;
        num = radius * Mathf.Cos(Time.time * speed);
        return num;
    }
    public static  Vector3 Random_Pos(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        float z = Random.Range(min, max);

        Vector3 Pos = new Vector3(x,y,z);
        return Pos;
    }
}
