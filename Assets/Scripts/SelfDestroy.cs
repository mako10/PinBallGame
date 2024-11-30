﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public float yDeathPos = -10.0f;

    private void Update()
    {
        if (this.gameObject.transform.position.y < yDeathPos)
        {
            Destroy(this.gameObject);
        }
    }
}
