using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceForce = 10.0f;
    public int scorePoint = 10;
    public GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball")) // タグが "Ball" であるか確認
        {
            Vector3 bounceDirection = other.contacts[0].normal;
            bounceDirection.y = 0; // y軸には跳ね返さない
            other.rigidbody.AddForce(-bounceDirection * bounceForce, ForceMode.Impulse);

            gameManager.GetComponent<GameManager>().AddScore(scorePoint);
        }
    }
}
