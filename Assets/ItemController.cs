using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour {

    //メインカメラ変数
    Camera cam;


    // Use this for initialization
    void Start () {

        //メインカメラをを取得
        cam = Camera.main;

    }

    // Update is called once per frame
    void Update () {

        //アイテムがカメラのz位置より小さい場合
        if (this.transform.position.z < cam.transform.position.z)
        {
           Destroy(gameObject);
        }

    }
}
