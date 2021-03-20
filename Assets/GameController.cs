using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject MainText;
    // Use this for initialization
    void Start () {
        MainText.SetActive (false);
    }
    
    // Update is called once per frame
    void Update () {
        
    }


    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.name == "bear") {
            Debug.Log ("ゴール！");
            MainText.SetActive (true);        }
    }
 

    // // 衝突した瞬間に呼ばれる  
    // void OnCollisionEnter(Collision collision) {  
    //     Debug.Log ("OnColider1");
    // }  
    // // 衝突している間呼ばれ続ける  
    // void OnCollisionStay(Collision collision) {  
    //     Debug.Log ("OnColider2");
    // }  
    // // 衝突から離れた瞬間に呼ばれる  
    // void OnCollisionExit(Collision collision) {  
    //     Debug.Log ("OnColider3");
    // }  
}

