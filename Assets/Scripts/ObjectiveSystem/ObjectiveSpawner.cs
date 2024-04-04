using UnityEngine;

// Spawns the starting objectives on game start


public class ObjectiveSpawner : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Test");
        PlayerController playerController = FindObjectOfType<PlayerController>();
        if (playerController != null)
        {
            ObjectiveManager objectiveManager = FindObjectOfType<ObjectiveManager>();
            if (objectiveManager != null)
            {
                GlobalManager.Instance.objectiveManager.InitializeSatelliteDishCollectObjective();
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
