using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(0, 10)]
    public float DeadSecond = 3f;
    [Range(0, 200)]
    public float Speed = 100f;

    public Vector3 StartPos { get; set; }
    public Vector3 TargetPos { get; set; }

    public GameObject _enemy;
    // private void Start() {
    //     _enemy = GameObject.FindGameObjectWithTag("Enemies");
    // }
    public void Init(Vector3 startPos, Vector3 targetPos)
    {
        _enemy = GameObject.FindGameObjectWithTag("Enemies");
        StartPos = startPos;
        if(_enemy != null && cheet._homing) TargetPos = _enemy.transform.position;
        else TargetPos = targetPos;
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        float time = 0f;
        transform.position = StartPos;
        var vec = (TargetPos - StartPos).normalized;
        while(time < DeadSecond)
        {
            time += Time.deltaTime;
            transform.position += vec * Speed * Time.deltaTime;
            yield return null;
        }

        Object.Destroy(gameObject);
    }
}