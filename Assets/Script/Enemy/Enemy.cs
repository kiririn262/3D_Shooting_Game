using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Range(0, 100)]
    [Header("Enemyの移動スピード")]
    public float Speed = 20;
    [Header("生存時間")]
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
        if(this.transform.childCount == 0) Destroy(this.gameObject);
        else{
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
}