using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArea : MonoBehaviour
{
    public GameObject[] EnemyList;
    [Header("敵の出現範囲")]
    public float Range = 10.0f;
    [Header("敵の出現距離")]
    public float Distance = 30.0f;

    // void Start()
    // {
    //     foreach(var enemy in EnemyList)
    //     {
    //         enemy.SetActive(false);
    //     }
    // }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            foreach (var enemy in EnemyList)
            {
                // enemy.SetActive(true);
                Vector3 new_Vector3 = this.gameObject.transform.position;
                new_Vector3.z += Distance;
                Instantiate(enemy, new_Vector3 + Code.Random_Pos(-1 * Range,Range), Quaternion.identity);
            }

            //一度敵を有効化したら、当たらないようにする
            var collider = GetComponent<Collider>();
            collider.enabled = false;
        }
    }
}