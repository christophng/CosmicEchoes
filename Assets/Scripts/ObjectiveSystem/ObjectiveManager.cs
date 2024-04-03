using UnityEngine;
using System.Collections.Generic;

// Handles objective management

public class ObjectiveManager : MonoBehaviour
{
    public List<IObjective> objectives = new List<IObjective>();

    public void InitializeObjectives(PlayerController playerController)
    {
        ObjectiveA objectiveA = new ObjectiveA(playerController);
        objectives.Add(objectiveA);
        Debug.Log("Added " + objectiveA.Name);

        // Add more objectives as needed
    }
}
