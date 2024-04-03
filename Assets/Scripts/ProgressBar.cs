
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{
    const int max = 100;
    public float current;
    public Image mask;
    public Animator anim;
 

    private void Start()
    {
        current = max;
    }
    void Update()
    {
        GetCurrentFill();

        
        if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.W)))
        {
            LoseFill(1);
        }

        if(current <= 0)
        {
            SceneManager.LoadScene("Death");
        }
        
               
    }

    public void GetCurrentFill()
    {
        Debug.Log(current);
        float fillAmount = (float)current / (float)max;
        mask.fillAmount = fillAmount;
    }

    public void LoseFill(int val)
    {

        current -= val;
        mask.fillAmount = current / max;



        //animation maybe


        
    }

    //public void Die()
    //{
    //    isDead = true;
    //}

    
}
