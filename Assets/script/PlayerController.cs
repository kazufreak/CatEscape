﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void LbuttonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RbuttonDown()
    {
        transform.Translate(3, 0, 0);
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);

        }
 
		
	}
}