using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    Player _player;
    void Start()
    {
        _player = Object.FindObjectOfType<Player>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 targetPos = _player.transform.position + _player.transform.forward;
            _player.ShotBullet(targetPos);
        }
    }
}
