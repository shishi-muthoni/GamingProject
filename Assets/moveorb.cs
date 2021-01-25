﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveorb : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;

    public float horizVel = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, 4);
        if (Input.GetKeyDown(moveL))
        {
            horizVel = -2;
            StartCoroutine(stopSlide());
        }
        if (Input.GetKeyDown(moveR))
        {
            horizVel = 2;
            StartCoroutine(stopSlide());
        }
    }
    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;

    }
}
