﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour {

    public int playerSpeed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed *
             Time.deltaTime;
        }

    }
}
