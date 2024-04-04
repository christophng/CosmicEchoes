using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Singleton instance
    private static Inventory instance;

    // Current item in the inventory
    private string currentItem = "";

    // Public property to access the singleton instance
    public static Inventory Instance
    {
        get
        {
            Debug.Log("INSTANTIATING INVENTORY");
            // If the instance hasn't been initialized yet, find or create it
            if (instance == null)
            {
                instance = FindObjectOfType<Inventory>();

                // If no instance exists in the scene, create a new GameObject and add the Inventory component to it
                if (instance == null)
                {
                    Debug.Log("MAKING NEW INVENTORY OBJ");
                    GameObject inventoryGameObject = new GameObject("Inventory");
                    instance = inventoryGameObject.AddComponent<Inventory>();
                }
            }
            return instance;
        }
    }

    // Add an item to the inventory (replaces the current item)
    public void AddItem(string newItem)
    {
        currentItem = newItem;
    }

    // Remove the current item from the inventory
    public void RemoveItem()
    {
        currentItem = "";
    }

    // Get the current item from the inventory
    public string GetCurrentItem()
    {
        return currentItem;
    }

    // Check if the inventory contains an item
    public bool ContainsItem()
    {
        return currentItem != "";
    }

    // Ensure that the instance is not destroyed when loading new scenes
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
