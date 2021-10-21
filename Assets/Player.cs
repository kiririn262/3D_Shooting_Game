using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Transform[] RoutePoints;

    [Range(0, 200)]
    [Header("プレイヤーのポイント間移動スピード")]
    public float Speed = 10f;

    [Range(0, 50)]
    [Header("キー入力による移動スピード(加速)")]
    public float MoveSpeed = 10f;
    [Header("キー入力による移動スピード(MAX値)")]
    public float MoveRange = 40f;

    [Header("HPの最大値")]
    public float _initialLife = 100;
    //public float Life = 100;
    private float Life;
    public Image LifeGage;

    bool _isHitRoutePoint;

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
        if(Life <= 0)
        {
            Camera.main.transform.SetParent(null);
            gameObject.SetActive(false);
            var sceneManager = Object.FindObjectOfType<SceneManager>();
            sceneManager.ShowGameOver();
        }
        else if(other.gameObject.tag == "ClearRoutePoint")
        {
            var sceneManager = Object.FindObjectOfType<SceneManager>();
            sceneManager.ShowClear();
            _isHitRoutePoint = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Background")
        {
            Life = 0;
            LifeGage.fillAmount = Life / _initialLife;

            Camera.main.transform.SetParent(null);
            gameObject.SetActive(false);
            var sceneManager = Object.FindObjectOfType<SceneManager>();
            sceneManager.ShowGameOver();
        }
    }

    void Start()
    {
        Life = _initialLife;
        StartCoroutine(Move());
    }
    public Bullet BulletPrefab;
    public void ShotBullet(Vector3 targetPos)
    {
        var bullet = Object.Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        bullet.Init(transform.position, targetPos);
    }
}