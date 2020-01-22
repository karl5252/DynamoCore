using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counters : MonoBehaviour
{
    public GameObject Player;
    private PlayerController playerScript;
    public Text ScoreCounter;
    public Text Lives;
    private string keyname = "highscore";
    // Start is called before the first frame update
    private void Awake()
    {
        playerScript = Player.GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.counter > 0)
        {
            CounterControl();
        }
        LifeCounter();

        PlayerPrefs.SetInt(keyname, playerScript.counter);
        Debug.Log("Current score: " + PlayerPrefs.GetInt("highscore").ToString());
    }
    void CounterControl()
    {
        if (playerScript.counter < 10)
        {
            ScoreCounter.text = "SCORE: " + "0" + playerScript.counter.ToString();
        }
        else
        {
            ScoreCounter.text = "SCORE: " + playerScript.counter.ToString();
        }

    }
    void LifeCounter()
    {
        Lives.text = "LIFE: " + playerScript.lCounter.ToString();

    }

}
