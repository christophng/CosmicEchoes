using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    private static GlobalManager instance;

    public GameObject pauseMenu;

    public GameObject objectivePopup;

    public PlayerController playerController;

    public ObjectiveManager objectiveManager;

    public static GlobalManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GlobalManager>();

                if (instance == null)
                {
                    GameObject obj = new GameObject("GlobalManager");
                    instance = obj.AddComponent<GlobalManager>();
                }
            }
            return instance;
        }
    }

    // Ensure the instance is not destroyed when reloading scenes
    private void Awake()
    {
        DontDestroyOnLoad(objectivePopup);
        DontDestroyOnLoad(playerController);
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(objectiveManager);
        DontDestroyOnLoad(pauseMenu);
    }
}
