using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour, IInteractable
{
    public float throwForce = 100f;

    private Rigidbody rb;
    private Rigidbody playerRb;
    private Transform player;
    private Transform myHands;
    private bool isPickedUp;
    private PickupObject pickupObject;
    private PlayerMove playerMove;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Astronaut").transform;
        playerRb = GameObject.Find("Astronaut").GetComponent<Rigidbody>();
        myHands = GameObject.Find("HoldPos").transform;
        pickupObject = GetComponent<PickupObject>();
        playerMove = GameObject.Find("Astronaut").GetComponent<PlayerMove>();
    }

    private void Update()
    {
        if (isPickedUp && Input.GetKeyDown(KeyCode.Mouse0))
        {
            throwObj();
        }
    }

    public void SetPickedUp(bool pickedUp)
    {
        isPickedUp = pickedUp;
    }

    private void throwObj()
    {
        playerMove.setDamping(0.05f);

        rb.useGravity = false;
        rb.isKinematic = false;
        GetComponent<BoxCollider>().enabled = true;

        transform.parent = null;
        rb.constraints = RigidbodyConstraints.None;

        Vector3 throwDirection = transform.position - myHands.position;
        throwDirection.Normalize();
        Debug.DrawLine(player.position, throwDirection, Color.yellow);

        rb.AddForce(myHands.forward * throwForce, ForceMode.Impulse);
        playerRb.AddForce(-myHands.forward * throwForce, ForceMode.Impulse);

        isPickedUp = false;


        pickupObject.isPickedUp = false;

    }

    public void Interact()
    {
        Debug.Log("Press f to pickup");
    }
}
