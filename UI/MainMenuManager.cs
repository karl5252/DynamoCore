using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    //public GameObject levelsubMenu;
    public GameObject highScoreSubMenu;
    public GameObject howToSubMenu;
    public GameObject mainMenu;

    public Text TextHighestScore;
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        
        hideSubMenus();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void hideSubMenus()
    {
        highScoreSubMenu.SetActive(false);
        howToSubMenu.SetActive(false);

    }
    public void showHighScore()
    {
        highScoreSubMenu.SetActive(true);
        howToSubMenu.SetActive(false);
    }
    public void showHowTo()
    {
        howToSubMenu.SetActive(true);
        highScoreSubMenu.SetActive(false);
    }
    public void LoadLevel(string level)
    {
        Application.LoadLevel(level);
    }
    public void highScore()
    {
        TextHighestScore.text = PlayerPrefs.GetInt("highscore").ToString();
    }
    public void exitGame()
    {
        Application.Quit();
    }







}
