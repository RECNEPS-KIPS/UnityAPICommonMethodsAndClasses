﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRotate : MonoBehaviour {
    private float start = 0;
    // Start is called before the first frame update
    void Start() {
        start = 0;
    }

    // Update is called once per frame
    void FixedUpdate() {
        Debug.Log(Time.time);
        start += 0.12f;
        transform.rotation=Quaternion.Euler(new Vector3(0,start,0));
    }
}
