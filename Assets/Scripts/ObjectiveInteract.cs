using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveInteract : MonoBehaviour
{
    public bool isInteract = false;
    private string parent;

    private void Update()
    {
        if (parent.Equals("ObjectiveDesk") && isInteract){

            if(Input.GetKeyDown(KeyCode.I))
            {
                Deposit();
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
    }


    public void Deposit()
    {
        Debug.Log("Deposit");
    }
}
