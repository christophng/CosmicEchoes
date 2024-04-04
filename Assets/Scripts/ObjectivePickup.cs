using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePickup : MonoBehaviour
    
{
    public bool isInteract;
    private string parent;

    private void Start()
    {
        isInteract = false;
        parent = "";
        DontDestroyOnLoad(gameObject);
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

        GlobalManager.Instance.playerController.CollectSatelliteDish();


        Debug.Log("item acquired");

        Inventory.Instance.AddItem(this.transform.parent.gameObject.name);

        Debug.Log("New inven: " + Inventory.Instance.GetCurrentItem());

        this.transform.parent.gameObject.SetActive(false);



    }
}
