using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Transform[] RoutePoints;

    [Range(0, 200)]
    public float Speed = 10f;

    bool _isHitRoutePoint;

    [Range(0, 50)]
    public float MoveSpeed = 10f;
    public float MoveRange = 40f;

    public float _initialLife = 100;
    public float Life = 100;
    public Image LifeGage;
    IEnumerator Move()
    {
        var prevPointPos = transform.position;
        var basePosition = transform.position;
        var movedPos = Vector2.zero;

        foreach (var nextPoint in RoutePoints)
        {
            _isHitRoutePoint = false; //必ずfalseにする

            while (!_isHitRoutePoint)
            {
                //進行方向の計算
                var vec = nextPoint.position - prevPointPos;
                vec.Normalize();

                // プレイヤーの移動
                basePosition += vec * Speed * Time.deltaTime;

                //上下左右に移動する処理
                // 行列によるベクトルの変換に関係する知識を利用しています。
                movedPos.x += Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
                movedPos.y += Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
                movedPos = Vector2.ClampMagnitude(movedPos, MoveRange);
                var worldMovedPos = Matrix4x4.Rotate(transform.rotation).MultiplyVector(movedPos);

                //ルート上の位置に上下左右の移動量を加えている
                transform.position = basePosition + worldMovedPos;

                //次の処理では進行方向を向くように計算している
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(vec, Vector3.up), 0.5f);

                yield return null;
            }
            prevPointPos = nextPoint.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "RoutePoint")
        {
            other.gameObject.SetActive(false);
            _isHitRoutePoint = true;
        }
        else if (other.gameObject.tag == "Enemies")
        {
            Life -= 10f;
            LifeGage.fillAmount = Life / _initialLife;

            other.gameObject.SetActive(false);
            Object.Destroy(other.gameObject); //当たった敵は削除する
        }
    }

    void Start()
    {
        StartCoroutine(Move());
    }
}