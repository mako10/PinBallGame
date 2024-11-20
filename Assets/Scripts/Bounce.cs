using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceForce = 10.0f;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball")) // タグが "Ball" であるか確認
        {
            Vector3 bounceDirection = other.contacts[0].normal;
            bounceDirection.y = 0; // y軸には跳ね返さない
            other.rigidbody.AddForce(-bounceDirection * bounceForce, ForceMode.Impulse);
        }
    }
}
