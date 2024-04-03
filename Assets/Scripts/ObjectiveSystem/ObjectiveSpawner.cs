using UnityEngine;

// Spawns the objectives


public class ObjectiveSpawner : MonoBehaviour
{
    void Start()
    {
        PlayerController playerController = FindObjectOfType<PlayerController>();
        if (playerController != null)
        {
            ObjectiveManager objectiveManager = FindObjectOfType<ObjectiveManager>();
            if (objectiveManager != null)
            {
                objectiveManager.InitializeObjectives(playerController);
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
