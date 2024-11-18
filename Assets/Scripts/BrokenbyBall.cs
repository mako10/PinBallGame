using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenbyBall : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(gameObject, 1.2f);
        }
    }
}
