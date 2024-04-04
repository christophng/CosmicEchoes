using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectivePopup : MonoBehaviour
{
    public TMP_Text objectiveText;
    public TextTypingAnimation textTypingAnimation;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        // Loop through all children of the parent GameObject
        foreach (Transform child in transform)
        {
            // Apply DontDestroyOnLoad to each child GameObject
            DontDestroyOnLoad(child.gameObject);
        }
    }
    
    // Call this method to update the objective description displayed in the popup
    public void SetObjectiveDescription(string description)
    {
        objectiveText.text = description;
        textTypingAnimation.StartTypingAnimation(description);
    }

    
}
