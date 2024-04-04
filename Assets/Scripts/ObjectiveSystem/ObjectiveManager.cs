using UnityEngine;
using System.Collections.Generic;

// Handles objective management

public class ObjectiveManager : MonoBehaviour
{

    private PlayerController playerController;

    void Start() {
        this.playerController = GlobalManager.Instance.playerController;
    }

    public void InitializeSatelliteDishCollectObjective()
    {
        // Find or create an empty GameObject to hold the objective script
        GameObject objectiveGO = new GameObject("SatelliteDishCollectObjective");
        
        // Add the SatelliteDishCollectObjective component to the GameObject
        SatelliteDishCollectObjective satelliteDishObjective = objectiveGO.AddComponent<SatelliteDishCollectObjective>();
        
        // Initialize the objective
        satelliteDishObjective.Initialize(playerController);

        // Make sure the objective persists across scene changes
        DontDestroyOnLoad(objectiveGO);
        
        Debug.Log("SPAWNING COLLECT");

        // objectiveManager.InitializeObjective(playerController);

    }

    public void InitializeSatelliteDishDepositObjective() {
        // Find or create an empty GameObject to hold the objective script
        GameObject objectiveGO = new GameObject("SatelliteDishDepositObjective");
        
        // Add the SatelliteDishCollectObjective component to the GameObject
        SatelliteDishDepositObjective satelliteDishObjective = objectiveGO.AddComponent<SatelliteDishDepositObjective>();
        
        // Initialize the objective
        satelliteDishObjective.Initialize(playerController);

        // Make sure the objective persists across scene changes
        DontDestroyOnLoad(objectiveGO);
        
        Debug.Log("SPAWNING DEPOSIT");
    }
}
