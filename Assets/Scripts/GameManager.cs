using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab; // �{�[���̃v���n�u
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ballObj = GameObject.Find("Ball"); // �{�[���̃I�u�W�F�N�g���擾
        if (ballObj == null) // �{�[���̃I�u�W�F�N�g���Ȃ��ꍇ
        {
            // �{�[���̃v���n�u�����Ƀ{�[���̃I�u�W�F�N�g�𐶐�
            GameObject newBall = Instantiate(ballPrefab);
            newBall.name = ballPrefab.name; // ���������{�[���̃I�u�W�F�N�g�̖��O��ݒ�
        }
    }
}
