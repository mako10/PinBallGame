using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int life; // ライフの変数
    public GameObject ballPrefab; // ボールのプレハブ
    public TextMeshProUGUI textGameover;

    // Start is called before the first frame update
    void Start()
    {
        life = 3; // ライフの初期値を設定
        textGameover.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ballObj = GameObject.Find("Ball"); // ボールのオブジェクトを取得
        if (ballObj == null) // ボールのオブジェクトがない場合
        {
            --life;
            if (life > 0)
            { 
            // ボールのプレハブを元にボールのオブジェクトを生成
            GameObject newBall = Instantiate(ballPrefab);
            newBall.name = ballPrefab.name; // 生成したボールのオブジェクトの名前を設定
            }
            else
            {
                life = 0; // ライフが0になったら
                textGameover.enabled = true;
            }
        }
    }
}
