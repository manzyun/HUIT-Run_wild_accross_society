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

    // Use this for initialization
    void Start () {
        // MainText.SetActive (false);
    }
    
    // Update is called once per frame
    void Update () {
        MainText.text = Math.Round(Time.time, 1,  MidpointRounding.AwayFromZero).ToString();    
    }


    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.name == "bear") {
            Debug.Log ("ゴール！");

            // MainText.SetActive (true);
        }
    }
 

  

}

