using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour {

    //Unityちゃんのオブジェクト
    private GameObject unitychan;


    // Use this for initialization
    void Start () {

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");       

    }

    // Update is called once per frame
    void Update () {

        //アイテムがユニティちゃんのz位置より小さい場合
        if (this.transform.position.z < unitychan.transform.position.z)
        {
           Destroy(gameObject);
        }

    }
}
