using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour
{

    float goal_time;
    // public GameObject MainText;
    public Text MainText;
    bool goal_bool;

    // Use this for initialization
    void Start () {
        goal_bool = false;
        // MainText.SetActive (false);
    }
    
    // Update is called once per frame
    void Update () {
        if (!goal_bool){
            MainText.text = Math.Round(Time.time, 1,  MidpointRounding.AwayFromZero).ToString(); 
        }
    }


    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.name == "bear") {
            Debug.Log ("ゴール！");    
            goal_bool = true; 
        }
    }
 

  

}

