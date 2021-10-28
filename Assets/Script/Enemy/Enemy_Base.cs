using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Base : MonoBehaviour
{
    // 次のフィールドを追加
    public float Life = 10;
    // 次のメソッドを追加
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Life -= 10;
            Object.Destroy(other.gameObject);

            if(Life <= 0)
            {
                Object.Destroy(gameObject);
                var sceneManager = Object.FindObjectOfType<SceneManager>();
                sceneManager.AddScore(1000);
            }
        }
    }
    // クリックされたらBulletを発射
    // Player _player;
    // void Start()
    // {
    //     _player = Object.FindObjectOfType<Player>();
    // }
    // private void OnMouseUpAsButton()
    // {
    //     _player.ShotBullet(transform.position);
    // }
}
