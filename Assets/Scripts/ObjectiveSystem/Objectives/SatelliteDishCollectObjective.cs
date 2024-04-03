using UnityEngine;

public class SatelliteDishCollectObjective : IObjective
{
    public bool isCompleted { get; set; }
    public string Name { get; set; }
    public PlayerController playerController { get; set; }

    public SatelliteDishCollectObjective(PlayerController playerController)
    {
        this.playerController = playerController;
        this.isCompleted = false;
        this.Name = "SatelliteDish";
        Debug.Log("CREATING");
        DisplayObjective("TESTING 123");
        // playerController.AppleCollectedEvent.AddListener(OnAppleCollected);
    }

    // Call this method to display the objective popup with the specified description
    public void DisplayObjective(string description)
    {
        Debug.Log("DISPLAYING");
        // Get the script component attached to the GameObject
        ObjectivePopup popupScript = GlobalManager.Instance.objectivePopup.GetComponent<ObjectivePopup>();

        // Check if the script component exists
        if (popupScript != null)
        {
            // Call a method from ObjectivePopup
            popupScript.SetObjectiveDescription(description);
            GlobalManager.Instance.objectivePopup.SetActive(true);
            Debug.Log("SETTING");
            GlobalManager.Instance.objectivePopup.SetActive(true);
            Debug.Log("SETTING2");
            // GlobalManager.Instance.objectivePopup.SetObjectiveDescription(description);
        }
        else
        {
            Debug.LogError("ObjectivePopup component not found on objectivePopup GameObject.");
        }
    }

    private void OnSatelliteDishCollect()
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
            Debug.Log("Objective SatelliteDish completed!");
            isCompleted = true;
            GlobalManager.Instance.objectivePopup.SetActive(false);

            // Initialize next objective here
        }
    }
}
