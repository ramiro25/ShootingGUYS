using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{ 
    public GameObject hero;
    public Text timeText;
    private float currentTime = 0f;

    void Update()
    {
        if(hero != null)
        {
            currentTime += Time.deltaTime;
            timeText.text = currentTime.ToString("0000");
        }
    }

}
