using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeSize : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.localScale = new Vector3(0.5f, 1, 0.5f);
        }

    }
}
