using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 45.0f; // 回転速度を設定

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // y軸を中心に時計回りに回転させる
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
