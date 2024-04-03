
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{
    const int max = 100;
    public float current;
    public Image mask;

    // constants for sigmoid function
    private const float X_OFFSET = 9.2f;
    private const float SCALE = 2f;

    private void Start()
    {
        current = max;
    }
    void Update()
    {
        GetCurrentFill();
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.W)))
        {
            LoseFill();
        }
    }

    public void GetCurrentFill()
    {
        float fillAmount = (float)current / (float)max;
        mask.fillAmount = fillAmount;
    }

    public void LoseFill()
    {
        //ERROR IS HERE i think

        float decreaseRate = 100f / (1 + Mathf.Exp(-0.5f * (current - X_OFFSET)/ SCALE ));

        current -= decreaseRate * Time.deltaTime;
        mask.fillAmount = current / max;
        current = Mathf.Clamp(current, 0, max);
    }

    
}
