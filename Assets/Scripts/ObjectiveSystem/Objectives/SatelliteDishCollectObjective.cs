using UnityEngine;
using System.Collections;

public class SatelliteDishCollectObjective : MonoBehaviour
{
    public bool isCompleted { get; set; }
    public string Name { get; set; }
    public PlayerController playerController { get; set; }

    public void Initialize(PlayerController playerController)
    {
        this.playerController = playerController;
        this.isCompleted = false;
        this.Name = "SatelliteDishCollect";
        Debug.Log("CREATING");
        DisplayObjective("Satellite Collect Objective TEST");
        playerController.SatelliteDishCollectedEvent.AddListener(OnSatelliteDishCollect);
    }

    // Call this method to display the objective popup with the specified description
    public void DisplayObjective(string description)
    {
        // Get the script component attached to the GameObject
        ObjectivePopup popupScript = GlobalManager.Instance.objectivePopup.GetComponent<ObjectivePopup>();

        // Check if the script component exists
        if (popupScript != null)
        {
            GlobalManager.Instance.objectivePopup.SetActive(false);
            // Call a method from ObjectivePopup
            popupScript.SetObjectiveDescription(description);
            GlobalManager.Instance.objectivePopup.SetActive(true);
            Debug.Log("SETTING");
            // GlobalManager.Instance.objectivePopup.SetObjectiveDescription(description);
        }
        else
        {
            Debug.LogError("ObjectivePopup component not found on objectivePopup GameObject.");
        }

        //FOR TESTING
        // Debug.Log("The current inventory: " + Inventory.Instance.GetCurrentItem());
        
    }

    private void OnSatelliteDishCollect(bool isCollect)
    {
        if (!isCompleted && isCollect)
        {
            Complete();
        }
    }

    public void Complete()
    {
        if (!isCompleted)
        {
            Debug.Log("Objective SatelliteDish completed!");
            isCompleted = true;
            // DisplayObjective("Objective SatelliteDish Collect completed!");

            // Start the coroutine to wait for 3 seconds
            // StartCoroutine(WaitAndProceed());

            GlobalManager.Instance.objectiveManager.InitializeSatelliteDishDepositObjective();
        }
    }

    // IEnumerator WaitAndProceed()
    // {
    //     // Wait for 3 seconds
    //     yield return new WaitForSeconds(5);

    //     // After 3 seconds, deactivate the objective popup
    //     GlobalManager.Instance.objectivePopup.SetActive(false);

    //     // Initialize next objective here
    //     SatelliteDishDepositObjective satelliteDishDepositObjective = new SatelliteDishDepositObjective(playerController);
    // }
}
