using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeKeeper : MonoBehaviour
{
    public float startTime = 60;
    public Text timer;
    public Text endGame;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateTimer();
        endGame.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;
        UpdateTimer();
        if(startTime <= 1)
        {
            endGame.text = "Game Over !";
            timer.text = "";
            //Application.Quit();
        }
    }
    public void UpdateTimer()
    {
        timer.text = Mathf.Round(startTime).ToString();
    }
}
