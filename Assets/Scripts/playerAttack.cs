﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour {

    public bool keyPressed;
    private float attackTime;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKeyDown("x") || playerController.buttonB == true)
        {
            attackTime = 0.5f;
            keyPressed = true;
        }

     
            attackTime -= Time.deltaTime;
            if (attackTime < 0f)
            {
                keyPressed = false;
            }


    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && keyPressed) {
            Destroy(collision.gameObject);
        }
    }
}
