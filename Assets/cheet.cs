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
    public static void Broken()
    {
        //GameObject[] objs = new GameObject();
        objs = GameObject.FindGameObjectsWithTag("enemies");
        Code.DestroyAll(objs);
    }
}
