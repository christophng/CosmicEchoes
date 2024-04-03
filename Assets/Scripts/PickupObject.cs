using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public Transform myHands;
    public GameObject playerObj;
    private Rigidbody rb;

    public float pickupDist;
    public float distanceBetweenObjects;

    public bool isPickedUp;

    public KeyCode pickupKey = KeyCode.E;

    private ThrowObject throwable;

    private PlayerMove playerMove;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerObj = GameObject.Find("Astronaut");
        myHands = GameObject.Find("HoldPos").transform;

        throwable = GetComponent<ThrowObject>();
        playerMove = GameObject.Find("Astronaut").GetComponent<PlayerMove>();

    }

    private void Update()
    {


        pickupDist = Vector3.Distance(transform.position, playerObj.transform.position);
        //distanceBetweenObjects = Vector3.Distance(transform.position, playerObj.transform.position);

        // pickup within 3.5 radius

        if (Input.GetKeyDown(KeyCode.E) && isPickedUp == false && myHands.childCount < 1 && pickupDist <= 2.5)
        {
            Pickup();

        }

        //drop
        if (isPickedUp == true && myHands.childCount == 1 && Input.GetKeyDown(KeyCode.Q))
        {
            Drop();

        }
        //destroy
        if (pickupDist >= 100f)
        {
            GameObject.Destroy(gameObject);
        }


    }

    private void Pickup()
    {

        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<BoxCollider>().enabled = false;

        transform.SetParent(myHands);
        this.transform.position = myHands.position;

        this.transform.parent = GameObject.Find("HoldPos").transform;

        rb.constraints = RigidbodyConstraints.FreezeAll;
        rb.velocity = playerObj.GetComponent<Rigidbody>().velocity;
        rb.angularVelocity = Vector3.zero;

        isPickedUp = true;

        playerMove.setDamping(1f);
        throwable.SetPickedUp(true);
    }

    private void Drop()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        transform.SetParent(null);
        isPickedUp = false;

        rb.constraints = RigidbodyConstraints.None;

    }
}
