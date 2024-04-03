using UnityEngine;
using UnityEngine.UI;

public class PauseScreen : MonoBehaviour
{
    void Start()
    {
        ShowPauseScreen();
    }

    private void Update()
    {
        // Check for P key press to show/hide the pause screen
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePauseScreen();
        }
    }

    public void OnContinueButtonClick()
    {
        // Hide screen when continue is clicked
        HidePauseScreen();
    }

    private void ShowPauseScreen()
    {
        GameObject pauseUI = GlobalManager.Instance.pauseMenu;
        Debug.Log(pauseUI);
        pauseUI.SetActive(true);
        Debug.Log("Showing Pause Screen");
        Time.timeScale = 0f; // Pause the game
    }

    private void HidePauseScreen()
    {
        GameObject pauseUI = GlobalManager.Instance.pauseMenu;
        pauseUI.SetActive(false);
        Debug.Log("Hiding Pause Screen");
        Time.timeScale = 1f; // Resume the game
    }

    private void TogglePauseScreen()
    {
        GameObject pauseUI = GlobalManager.Instance.pauseMenu;
        Debug.Log("TOGGLE");
        if (pauseUI.activeSelf)
        {
            HidePauseScreen();
        }
        else
        {
            ShowPauseScreen();
        }
    }
}
