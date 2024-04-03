using UnityEngine;
using System.Collections.Generic;

// Handles objective management

public class ObjectiveManager : MonoBehaviour
{
    public List<IObjective> objectives = new List<IObjective>();

    public void InitializeObjective(PlayerController playerController)
    {
        // ObjectiveA objectiveA = new ObjectiveA(playerController);
        // objectives.Add(objectiveA);
        // Debug.Log("Added " + objectiveA.Name);

        // SatelliteDishCollectObjective satteliteDishCollectObjective = new SatelliteDishCollectObjective(playerController);
        // objectives.Add(satteliteDishCollectObjective);
        // Debug.Log("Added " + satteliteDishCollectObjective.Name);

        // These are the initial objectives. we should only initialize these first

        // Actually, since its pretty straightforward to initialize (its literally just creating an instance of the objective class and we can call PlayerController via GlobalManager) this isnt neccessary right now

        // Add more objectives as needed
    }
}
