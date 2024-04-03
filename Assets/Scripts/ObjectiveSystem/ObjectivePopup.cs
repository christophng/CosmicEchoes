using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectivePopup : MonoBehaviour
{
    public TMP_Text objectiveText;
    public TextTypingAnimation textTypingAnimation;

    // Call this method to update the objective description displayed in the popup
    public void SetObjectiveDescription(string description)
    {
        objectiveText.text = description;
        textTypingAnimation.StartTypingAnimation(description);
    }
}
