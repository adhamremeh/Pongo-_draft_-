﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMenu : MonoBehaviour
{

    private Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("ball").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bin"))
        {
            transform.position = spawn.position;
        }
    }
}
