using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = -160;
    //ゴール地点
    private int goalPos = 120;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;

    //次にアイテムを生成する z 座標
    float nextItemGeneratePosition;
    //unityちゃん
    GameObject unitychan;


    // Use this for initialization
    void Start () {

        //unityちゃんゲームオブジェクト取得
        unitychan = GameObject.Find("unitychan");
       
        //nextItemGeneratePositionの値
        nextItemGeneratePosition = unitychan.transform.position.z + 15;


    }


    // Update is called once per frame
    void Update () {



        //unityちゃんのｚ位置とnextItemGeneratePositionの値が同じになったら
        if (unitychan.transform.position.z >= nextItemGeneratePosition)
        {
            
            //nextItemGeneratePositionの値を更新
            nextItemGeneratePosition = unitychan.transform.position.z + 100;


            //unityちゃんのｚ位置＋５０と、nextItemGeneratePositionの間にアイテムを生成
            for (float i = unitychan.transform.position.z + 50; i < nextItemGeneratePosition; i += 15)
        {
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {

                //レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //60%コイン配置:30%車配置:10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);

                    }
                }
            }
        }


    }





    }


}
