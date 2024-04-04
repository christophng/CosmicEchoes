using System.Collections;
using UnityEngine;
using TMPro;

public class TextTypingAnimation : MonoBehaviour
{
    public float typingSpeed = 0.1f; // Speed at which each letter appears
    public TMP_Text textElement; // Reference to your UI text element

    private string fullText; // Full text to be revealed

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void StartTypingAnimation(string newText)
    {
        fullText = newText;
        textElement.text = ""; // Clear the text initially
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in fullText)
        {
            textElement.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
