using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class cheet
{
    private static GameObject[] objs;
    public static bool _homing = false;
    public static bool _fullauto = false;
    public static bool _frog = false;


    public static void Frog(GameObject _Frog)
    {
        _frog = !_frog;
        _Frog.SetActive(_frog);
    }
    public static void FullAuto()
    {
        _fullauto = !_fullauto;
        GameObject _Event = GameObject.Find("Event");
        if(_fullauto) _Event.GetComponent<BulletController>().Shoot_num = 100;
        else _Event.GetComponent<BulletController>().Shoot_num = 4;
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
        _mainCamera.transform.localPosition =new Vector3 (0,2,-8);
    }
    public static void boost(float num)
    {
        GameObject _player = GameObject.FindGameObjectWithTag("Player");
        _player.GetComponent<Player>().Speed = num;
    }
    public static void Homing()
    {
        _homing = !_homing;
    }
}
