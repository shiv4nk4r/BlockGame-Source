﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{

    public float gravityScaleFactor = 20f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScaleFactor;
    }
    void Update()
    {
        if(transform.position.y < -2f)
        {
            Destroy(gameObject);
        }       
    }
}
