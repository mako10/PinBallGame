using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 45.0f; // ‰ñ“]‘¬“x‚ğİ’è

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // y²‚ğ’†S‚ÉŒv‰ñ‚è‚É‰ñ“]‚³‚¹‚é
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
