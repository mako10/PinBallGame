using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject); // 衝突したオブジェクトを破壊する
        }
    }
}
