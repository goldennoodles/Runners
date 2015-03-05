﻿using UnityEngine;
using System.Collections;

public class charactermovescript : MonoBehaviour {

    public float speed = 6.0F;

    public float jumpSpeed = 8.0F;

    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}

    void Update()
    {

        Movements();
        SprintFunc();

    }
	
	// Update is called once per frame
    void Movements() {

        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded) {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }

        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    }

    void SprintFunc()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10f;
        }
    }

}