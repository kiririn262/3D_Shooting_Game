using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float time;
    public int Shoot_num;
    Player _player;
    void Start()
    {
        _player = Object.FindObjectOfType<Player>();
    }
    private void Update()
    {
        time += Time.deltaTime;
        if(time >= 1.0f / Shoot_num){
            if(Input.GetKey(KeyCode.Space))
            {
                time = 0;
                Vector3 targetPos = _player.transform.position + _player.transform.forward;
                _player.ShotBullet(targetPos);
            }
        }
    }
}
