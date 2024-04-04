using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveInteract : MonoBehaviour
{
    public bool isInteract;
    private string parent;
    private void Start()
    {
        isInteract = false;
        parent = "";
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
        Debug.Log("trigger enter");
        parent = this.gameObject.transform.parent.name;
        isInteract = true;

    }

    private void OnTriggerExit(Collider other)
    {
        isInteract = false;
    }


    public void Deposit()
    {
        /**
        * Chris put ur code here
        */
        Debug.Log("Deposit");
    }
}
