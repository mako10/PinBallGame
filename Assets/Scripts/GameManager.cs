using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab; // ボールのプレハブ
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ballObj = GameObject.Find("Ball"); // ボールのオブジェクトを取得
        if (ballObj == null) // ボールのオブジェクトがない場合
        {
            // ボールのプレハブを元にボールのオブジェクトを生成
            GameObject newBall = Instantiate(ballPrefab);
            newBall.name = ballPrefab.name; // 生成したボールのオブジェクトの名前を設定
        }
    }
}
