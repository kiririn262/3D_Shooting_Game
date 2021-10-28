using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyComponent : Enemy_Base
{
    [SerializeField]
    private GameObject Base;
    [SerializeField]
    private GameObject Component;
    [SerializeField]
    [Range(1.0f, 50.0f)]
    private float speed = 1.0f;
    [SerializeField]
    [Range(0f, 90.0f)]
    private float radius = 5.0f;
    private float x,y,z;

    private enum Attack
    {
        None,
        Tornado,
        Lightning,
        Around,
        a,
        b,
        c
    }
    [SerializeField]
    private Attack type;

    void Update()
    {
        if(!(Component.gameObject == null)) ComponentMove(Base);
        else Destroy(this.gameObject);
    }

    private void ComponentMove(GameObject obj)
    {
        switch(type){
            // パターン1
            case Attack.None:
                //Destory(Component);
                break;

            // パターン2
            case Attack.Tornado:
                x = Code.Col_Cos(radius, speed);
                x = x + obj.transform.position.x;
                y = Code.Col_Cos(radius, speed / 3);
                y = y + obj.transform.position.y;
                z = Code.Col_Sin(radius, speed);
                z = z + obj.transform.position.z;
                break;

            // パターン3
            case Attack.Lightning:
                x = Code.Col_Sin(radius, speed);
                x = x + obj.transform.position.x;
                y = Code.Col_Cos(radius, speed);
                y = y + obj.transform.position.y;
                z = Code.Col_Cos(radius, speed * 3);
                z = z + obj.transform.position.z;
                break;

            case Attack.Around:
                x = Code.Col_Sin(radius, speed);
                x = x + obj.transform.position.x;
                y = Code.Col_Cos(radius, speed);
                y = y + obj.transform.position.y;
                z = Code.Col_Cos(radius, speed / 2);
                z = z + obj.transform.position.z;
                break;

            case Attack.a:
                x = Code.Col_Sin(radius, speed);
                x = x + obj.transform.position.x;
                y = Code.Col_Sin(radius, speed);
                y = y + obj.transform.position.y;
                z = Code.Col_Sin(radius, speed / 3);
                z = z + obj.transform.position.z;
                break;

            case Attack.b:
                x = Code.Col_Sin(radius, speed);
                x = x + obj.transform.position.x;
                y = Code.Col_Sin(radius, speed);
                y = y + obj.transform.position.y;
                z = Code.Col_Cos(radius, speed / 3);
                z = z + obj.transform.position.z;
                break;

            case Attack.c:
                x = Code.Col_Cos(radius, speed);
                x = x + obj.transform.position.x;
                y = Code.Col_Sin(radius, speed);
                y = y + obj.transform.position.y;
                z = Code.Col_Cos(radius, speed / 3);
                z = z + obj.transform.position.z;
                break;
        }
        Component.transform.position = new Vector3 (x, y, z);
    }
}
