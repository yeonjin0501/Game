﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnareDisappear : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
