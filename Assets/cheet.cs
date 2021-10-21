using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class cheet
{
    private static GameObject[] objs;

    public static void Max_HP()
    {
        //
    }
    public static void fps()
    {
        GameObject _mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        //_mainCamera.transform.position = new Vector3 (_mainCamera.transform.position.x,_mainCamera.transform.position.y,3);
        _mainCamera.transform.localPosition =new Vector3 (0,0,3);
    }
    public static void tps()
    {
        GameObject _mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        //_mainCamera.transform.localPosition = new Vector3 (_mainCamera.transform.position.x,_mainCamera.transform.position.y,-8);
        _mainCamera.transform.localPosition =new Vector3 (0,0,-8);
    }
    public static void boost(float num)
    {
        GameObject _player = GameObject.FindGameObjectWithTag("Player");
        _player.GetComponent<Player>().Speed = num;
    }
    public static void broken()
    {
        //GameObject[] objs = new GameObject();
        objs = GameObject.FindGameObjectsWithTag("enemies");
        Code.DestroyAll(objs);
    }
}
