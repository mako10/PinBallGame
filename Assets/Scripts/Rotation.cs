using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 45.0f; // ��]���x��ݒ�

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // y���𒆐S�Ɏ��v���ɉ�]������
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
