﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject pinPrefab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position,transform.rotation);
    }


}
