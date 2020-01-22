using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour
{
    public float totalTime = 120f; //60f = 1 minute
    public float bonusTime;
    public Text Timer;
    public GameObject Player;
    private PlayerController playerScript;
    void Awake()
    {
        playerScript = Player.GetComponent<PlayerController>();
    }
    private void Update()
    {
        totalTime -= Time.deltaTime;
        AddTime();
        UpdateLevelTimer(totalTime);
        
    }

    public void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

        Timer.text ="00:" + minutes.ToString("00") + ":" + seconds.ToString("00");
    }
    public void AddTime()
    {
        if (playerScript.timerIncrease == true)
        {
            totalTime = totalTime + bonusTime;
            playerScript.timerIncrease = false;
        }
    }
}
