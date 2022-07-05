﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    TankControler tankController;

    float movement;
    float rotation;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f,3f,-4f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        if (rotation != 0)
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
    }

    void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankControler _tankControler)
    {
        tankController = _tankControler;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
