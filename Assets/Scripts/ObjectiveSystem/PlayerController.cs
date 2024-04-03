// Bridge between objective system and the player interactions

using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public UnityEvent<int> AppleCollectedEvent = new UnityEvent<int>();

    private int applesCollected = 0;
    public int RequiredApples { get; set; } = 10; // Set the required number of apples

    public void CollectApple()
    {
        applesCollected++;
        AppleCollectedEvent.Invoke(applesCollected);
    }
}

