using UnityEngine;

public class SatelliteDishDepositObjective : IObjective
{
    public bool isCompleted { get; set; }
    public string Name { get; set; }
    public PlayerController playerController { get; set; }

    public SatelliteDishDepositObjective(PlayerController playerController)
    {
        this.playerController = playerController;
        this.isCompleted = false;
        this.Name = "SatelliteDishDeposit";
        Debug.Log("CREATING 123");
        DisplayObjective("Satellite Deposit TEST");
        playerController.SatelliteDishDepositEvent.AddListener(OnSatelliteDishDeposit);
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

    private void OnSatelliteDishDeposit()
    {
        if (!isCompleted)
        {
            Complete();
        }
    }

    public void Complete()
    {
        if (!isCompleted)
        {
            Debug.Log("Objective SatelliteDish Deposit completed!");
            isCompleted = true;
            DisplayObjective("Objective SatelliteDish Deposit completed!")

            // Start the coroutine to wait for 3 seconds
            StartCoroutine(WaitAndProceed());
        }
    }

    IEnumerator WaitAndProceed()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(5);

        // After 3 seconds, deactivate the objective popup
        GlobalManager.Instance.objectivePopup.SetActive(false);

        // Initialize the next objective here
    }
}
