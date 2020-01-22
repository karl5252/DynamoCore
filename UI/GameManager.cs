using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    private PlayerController playerScript;
    public string nextLevel;
    void Awake()
    {
        playerScript = Player.GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1 && playerScript.alive == true && playerScript.winner == true)
        {
            PlayerPrefs.GetInt("highscore");
            PlayerPrefs.Save();
            Time.timeScale = 0;
            LoadLevel(nextLevel);
        }
    }
    //loads inputted level
    public void LoadLevel(string level)
    {
        Application.LoadLevel(level);
    }
}
