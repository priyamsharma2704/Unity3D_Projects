﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float speed = 100f;

    void Update()
    {
        transform.Rotate(0f,0f,speed * Time.deltaTime );
    }
}
