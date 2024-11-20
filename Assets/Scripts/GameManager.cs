using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int life; // ���C�t�̕ϐ�
    public GameObject ballPrefab; // �{�[���̃v���n�u
    public TextMeshProUGUI textGameover;

    // Start is called before the first frame update
    void Start()
    {
        life = 3; // ���C�t�̏����l��ݒ�
        textGameover.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ballObj = GameObject.Find("Ball"); // �{�[���̃I�u�W�F�N�g���擾
        if (ballObj == null) // �{�[���̃I�u�W�F�N�g���Ȃ��ꍇ
        {
            --life;
            if (life > 0)
            { 
            // �{�[���̃v���n�u�����Ƀ{�[���̃I�u�W�F�N�g�𐶐�
            GameObject newBall = Instantiate(ballPrefab);
            newBall.name = ballPrefab.name; // ���������{�[���̃I�u�W�F�N�g�̖��O��ݒ�
            }
            else
            {
                life = 0; // ���C�t��0�ɂȂ�����
                textGameover.enabled = true;
            }
        }
    }
}
