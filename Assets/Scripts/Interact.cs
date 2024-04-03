
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

interface IInteractable
{
    public void Interact();
}

public class Interact : MonoBehaviour
{
    public bool isInRange;
    public GameObject interactUI;
    public GameObject panel;
    public GameObject pickupUI;
    public GameObject throwUI;
    private string parent;


    private Scene activeScene;
    

    private void Start()
    {
        activeScene = SceneManager.GetActiveScene();
        
    }



    private void Update()
    {
        if (isInRange)
        {
            EnableComponent();
            ChangeScene();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        parent = this.gameObject.transform.parent.name;
        Debug.Log($"{this.gameObject.transform.parent.name}");
        if (col.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("player in range");
        }
        if(parent.Equals("hangar_roundA"))
        {
            pickupUI.GetComponentInChildren<Text>().text = "F";
            
        }

        if (!parent.Equals("hangar_roundA")){
            pickupUI.GetComponentInChildren<Text>().text = "E";

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            DisableComponent();
            Debug.Log("player not in range");
        }
    }

    private void EnableComponent()
    {
        panel.SetActive(true);
        pickupUI.SetActive(true);

    }
    private void DisableComponent()
    {
        panel.SetActive(false);
        pickupUI.SetActive(false);
    }

    private void ChangeScene()
    {
        if (activeScene.name.Equals("Spaceship"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Space");
            }
        }
        if (activeScene.name.Equals("Space"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene("Spaceship");
            }
        }
    }

}
