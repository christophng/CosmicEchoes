// Bridge between objective system and the player interactions

using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{    
    // Satellite Dish Collect EVENT
    public UnityEvent<bool> SatelliteDishCollectedEvent = new UnityEvent<bool>();

    // Satellite Dish Deposit EVENT
    public UnityEvent<bool> SatelliteDishDepositEvent = new UnityEvent<bool>();

    public void CollectSatelliteDish() {
        SatelliteDishCollectedEvent.Invoke(true);
    }

    public void DepositSatelliteDish() {
        SatelliteDishDepositEvent.Invoke(true);
    }
}

