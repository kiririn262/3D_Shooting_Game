using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Range(0, 100)]
    public float Speed = 10;
    public float DeadSecond = 10f;

    float _time;
    Player _player;
    void Start()
    {
        _time = 0f;
        _player = Object.FindObjectOfType<Player>();
    }

    void Update()
    {
        _time += Time.deltaTime;
        if (_time >= DeadSecond)
        {
            Object.Destroy(gameObject);
        }
        else
        {
            var vec = _player.transform.position - transform.position;
            transform.position += vec.normalized * Speed * Time.deltaTime;
        }

    }
}