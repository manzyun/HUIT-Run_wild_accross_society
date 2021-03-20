
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearMove : MonoBehaviour
{
    Rigidbody rb;

    Vector3 startPos;
    Vector3 goalPos;

    Vector3 bearPos;
    public Vector3 bearSpeed;

    Vector3 rightMove;
    Vector3 leftMove;

    float jumpForce;
    float speedUp;

    void Start()
    {
        this.rb = GetComponent<Rigidbody>();

        // クマの初期位置設定
        this.startPos = new Vector3(0.0f,1.0f, 0.0f);
        this.transform.position = this.startPos;

        // ゴール位置設定
        this.goalPos = new Vector3(100.0f, 0.0f, 0.0f);

        // ゴールはゲームオブジェクトの方で設定する


        // クマの移動速度を設定
        this.bearSpeed = new Vector3(5.0f, 0.0f, 0.0f);

        this.speedUp = 1.005f;

        this.rightMove = new Vector3(0.0f, 0.0f, 10.0f);

        //左の移動
        this.leftMove = new Vector3(0.0f, 0.0f, -10.0f);

        // ジャンプする力を設定
        this.jumpForce = 3000.0f;

    }

    void Update()
    {
        // クマの位置情報を取得
        this.bearPos = GameObject.Find("bear").transform.position;

        // ゴールまで移動する
        if(this.bearPos.x <= goalPos.x)
        {
            this.rb.velocity = this.bearSpeed;
            bearSpeed.x *= speedUp;
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            this.rb.velocity = this.rightMove;
        }else if(Input.GetKey(KeyCode.LeftArrow)){
            this.rb.velocity = this.leftMove;
        }
    }
        // ジャンプ

    void OnCollisionStay(Collision collision)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.rb.AddForce(transform.up * jumpForce);
        }
    }

}






 
