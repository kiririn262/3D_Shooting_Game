using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyComponent : MonoBehaviour
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

    void Update()
    {
        ComponentMove(Base);
    }

    private void ComponentMove(GameObject obj)
    {
        x = Code.Col_Sin(radius, speed);
        y = Code.Col_Cos(radius, speed);
        y = y + obj.transform.position.y;
        z = Code.Col_Cos(radius, speed * 3);
        z = z + obj.transform.position.z;

        Component.transform.position = new Vector3 (x, y, z);
    }
}
