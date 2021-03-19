using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 障害物のオブジェクトObstacleにコンポーネントBoxcolliderを用意しisTrigerにチェック
//　クマのオブジェクトbearにBoxcolliderを二つ用意し片方isTrigerをチェックもう片方にはチェック入れない
public class Obstacle_script : MonoBehaviour
{
    Rigidbody rb;
    GameObject bear;
    BearMove bearmove;
    float speedDown;

    // Start is called before the first frame update
    void Start()
    {

        this.rb = GetComponent<Rigidbody>();
        bear = GameObject.Find("bear");
        bearmove = bear.GetComponent<BearMove>();
        speedDown = 0.5f;

    }

    // Update is called once per frame

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("衝突");
        bearmove.bearSpeed.x *= speedDown;
    }
}


  

 