using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePickup : MonoBehaviour
    
{
    public bool isInteract;
    private string parent;
    private Transform storage;

    private void Start()
    {
        isInteract = false;
        parent = "";
        storage = GameObject.Find("Storage").transform;
    }
    private void Update()
    {
        if (isInteract == true)
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {

                Storage();
            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            parent = this.gameObject.transform.parent.name;
            isInteract = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        isInteract = false;
        parent = "";
    }
    public void Storage()
    {
        // say item acquired
        // store item in object, hide object
        Debug.Log("item acquired");

        this.transform.parent.parent = storage;
        this.transform.parent.gameObject.SetActive(false);



    }
}
