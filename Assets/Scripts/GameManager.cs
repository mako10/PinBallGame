using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.ComponentModel;

public class GameManager : MonoBehaviour
{
    public int life; // ライフの変数
    public GameObject ballPrefab; // ボールのプレハブ
    public TextMeshProUGUI textGameover;

    private int score; // スコアの変数
    private TextMeshProUGUI textScore; // スコアを表示するテキスト

    private TextMeshProUGUI textBalls;
    private bool inGame;

    private float remainTime;
    private TextMeshProUGUI textTime;

    public TextMeshProUGUI textClear;


    // Start is called before the first frame update
    void Start()
    {
        life = 3; // ライフの初期値を設定
        textGameover.enabled = false;
        textClear.enabled = false;


        score = 0; // スコアの初期値を設定
        remainTime = 30.0f;


        textScore = GameObject.Find("Score").GetComponent<TextMeshProUGUI>(); // スコアを表示するテキストを取得
        textBalls = GameObject.Find("Balls").GetComponent<TextMeshProUGUI>();
        textTime = GameObject.Find("Time").GetComponent<TextMeshProUGUI>();


        SetScoreText(score);
        SetBallsText(life);
        inGame = true;
    }

    private void SetBallsText(int life)
    {
        textBalls.text = "Balls: " + life.ToString(); // ライフを表示するテキストにライフを設定
    }

    private void SetScoreText(int score)
    {
        textScore.text = "Score: " + score.ToString(); // スコアを表示するテキストにスコアを設定
    }

    public void AddScore(int point)
    {
        if (inGame)
        {
            score += point; // スコアを加算
            SetScoreText(score); // スコアを表示するテキストを更新
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inGame)
        {
            remainTime -= Time.deltaTime;
            textTime.text = "Time: " + (remainTime > 0.0f ? remainTime.ToString("0:00"):"0:00");

            if (remainTime <= 0.0f)
            {
                textGameover.enabled = true;
                inGame = false;
            }

            GameObject ballObj = GameObject.Find("Ball"); // ボールのオブジェクトを取得
            if (ballObj == null) // ボールのオブジェクトがない場合
            {
                --life;
                SetBallsText(life); // ライフを表示するテキストを更新
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
                    inGame = false;
                }
            }
            GameObject targetObj = GameObject.FindWithTag("Target");
            if (targetObj == null)
            {
                textClear.enabled = true;
                inGame = false;
            }
        }
    }
}
