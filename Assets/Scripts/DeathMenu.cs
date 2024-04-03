using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene("Space");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
