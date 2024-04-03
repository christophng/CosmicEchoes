using UnityEngine;

public class ObjectiveA : IObjective
{
    public bool isCompleted { get; set; }
    public string Name { get; set; }
    public PlayerController playerController { get; set; }

    public ObjectiveA(PlayerController playerController)
    {
        this.playerController = playerController;
        this.isCompleted = false;
        this.Name = "ObjectiveA";
        playerController.AppleCollectedEvent.AddListener(OnAppleCollected);
    }

    private void OnAppleCollected(int applesCollected)
    {
        if (!isCompleted && applesCollected >= playerController.RequiredApples)
        {
            Complete();
        }
    }

    public void Complete()
    {
        if (!isCompleted)
        {
            Debug.Log("Objective A completed!");
            isCompleted = true;
        }
    }
}
