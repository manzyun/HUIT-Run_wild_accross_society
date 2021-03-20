using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour
{
    GameObject bear;
    BearMove bearmove;


    float goal_time;
    public Text MainText;
    bool goal_bool;

    // Use this for initialization
    void Start () {
        goal_bool = false;
        bear = GameObject.Find("bear");
        bearmove = bear.GetComponent<BearMove>();
    }
    
    // Update is called once per frame
    void Update () {
        if (!goal_bool){
            MainText.text = Math.Round(Time.time, 1,  MidpointRounding.AwayFromZero).ToString(); 
        }
        if (goal_bool){
            bearmove.bearSpeed.x = 0;
        }
    }


    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.name == "bear") {
            Debug.Log ("ゴール！");    
            goal_bool = true; 
        }
    }
 

  

}



