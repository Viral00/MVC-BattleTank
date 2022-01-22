﻿using UnityEngine;

public class TankView: MonoBehaviour
{
    //public CharacterController Controller;
    //public Transform Cam;
    public TankController tankcontroller;
    //private float turnSmoothVelocity;
    private Rigidbody rb;
    private Vector3 rotate;

    public TankView(TankController tankController)
    {
        TankController = tankController;
    }
    public TankController TankController { get; }

    public void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical1");
        tankcontroller.TankMovement(vertical, rb, transform);
        tankcontroller.TankRotation(rotate, transform);
    }
}
