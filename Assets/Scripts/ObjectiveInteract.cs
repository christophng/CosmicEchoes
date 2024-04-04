using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectiveInteract : MonoBehaviour
{
    public bool isInteract;
    private string parent;
    private void Start()
    {
        isInteract = false;
        parent = transform.parent != null ? transform.parent.name : "";
    }

    private void Update()
    {
        if (isInteract)
        {
            if (parent.Equals("ObjectiveDesk")){
                if(Input.GetKeyDown(KeyCode.I))
                {
                    Deposit();
                }
            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        parent = this.gameObject.transform.parent.name;
        isInteract = true;

    }

    private void OnTriggerExit(Collider other)
    {
        isInteract = false;
        parent = "";
    }


    public void Deposit()
    {
        /**
        * Chris put ur code here
        */

        if (Inventory.Instance.GetCurrentItem().Equals("satelliteDish")) {
            Debug.Log("OBJECTIVE COMPLETED");
            GlobalManager.Instance.playerController.DepositSatelliteDish();
            Inventory.Instance.RemoveItem();
        }

        Debug.Log("Deposit");
    }

    
}
