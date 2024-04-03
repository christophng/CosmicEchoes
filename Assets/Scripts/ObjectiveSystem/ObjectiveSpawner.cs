using UnityEngine;

// Spawns the starting objectives on game start


public class ObjectiveSpawner : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Test");
        PlayerController playerController = FindObjectOfType<PlayerController>();
        if (playerController != null)
        {
            ObjectiveManager objectiveManager = FindObjectOfType<ObjectiveManager>();
            if (objectiveManager != null)
            {

                // Here we spawn the starting objectives when the game starts

                // objectiveManager.InitializeObjective(playerController);
                
                SatelliteDishCollectObjective satteliteDishCollectObjective = new SatelliteDishCollectObjective(playerController);

                // objectiveManager.InitializeObjective(playerController);
            }
            else
            {
                Debug.LogError("ObjectiveManager not found!");
            }
        }
        else
        {
            Debug.LogError("PlayerController not found!");
        }
    }
}
