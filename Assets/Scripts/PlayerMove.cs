using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 moveDir;
    //public Vector3 inputKey;
    [SerializeField] float speed = 0.7f;
    [SerializeField] float rotationSpeed = 10f;
    [SerializeField] private float damping = 1f;

 
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //inputKey = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.useGravity = false;
       
    }

    private void Update()
    {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");

        moveDir = new Vector3(horInput, 0f, verInput).normalized;

        if (moveDir != Vector3.zero)
        {
            Quaternion rotation = Quaternion.LookRotation(moveDir);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

        }

    }

    private void FixedUpdate()
    {
        //rb.velocity = moveDir * speed;
        rb.AddForce(moveDir * speed, ForceMode.Impulse);

        rb.velocity *= (1 - damping * Time.deltaTime);

    }

    public void setDamping(float val)
    {
        damping = val;
    }

   
}
