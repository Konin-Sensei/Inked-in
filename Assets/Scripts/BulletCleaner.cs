﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCleaner : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Bullet"){
            Destroy(other.gameObject);
        }
    }
}
