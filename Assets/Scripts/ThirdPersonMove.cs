using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMove : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 5f;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
