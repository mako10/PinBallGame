using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Broken : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collided with has the tag "Ball"
        if (collision.gameObject.tag == "Player")
        {
            // Destroy this game object
            Destroy(gameObject, 0.2f);
        }
    }
}
