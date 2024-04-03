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
        DisplayObjective("TESTING 123");
        // playerController.AppleCollectedEvent.AddListener(OnAppleCollected);
    }

    // Call this method to display the objective popup with the specified description
    public void DisplayObjective(string description)
    {
        GlobalManager.Instance.objectivePopup.SetObjectiveDescription(description);
        GlobalManager.Instance.objectivePopup.gameObject.SetActive(true);

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
            GlobalManager.Instance.objectivePopup.gameObject.SetActive(false);

            // Initialize next objective here
        }
    }
}
