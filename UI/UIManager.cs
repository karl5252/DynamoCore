using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIManager : MonoBehaviour
{

    public GameObject Player;
    private PlayerController playerScript;



    public GameObject pauseMenu;
	public GameObject gameOverMenu;

    public Text powerUpIndicator;
	//PlayerController playerController;
    void Awake()
    {
        playerScript = Player.GetComponent<PlayerController>();
        
    }


    // Use this for initialization
    void Start () {
		Time.timeScale = 1;

		

		hidePaused();
		hideFinished();

		//Checks to make sure MainLevel is the loaded level
		//if(Application.loadedLevelName == "Test_Scene")
			//playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
			//Debug.Log(playerScript.name);

     
	}

	// Update is called once per frame
	void Update () {

        if (playerScript.speedBoostActive == true)
        {
            powerUpIndicator.text = "<<";
        } else
        {
            powerUpIndicator.text = "";
        }
        

		//uses the p button to pause and unpause the game
		if(Input.GetKeyDown(KeyCode.P))
		{
			if(Time.timeScale == 1 && playerScript.alive == true)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0 && playerScript.alive == true){
				Time.timeScale = 1;
				hidePaused();
			}
		}

		//shows finish gameobjects if player is dead and timescale = 0
		if (Time.timeScale == 1 && playerScript.alive == false)
        {
			Time.timeScale = 0;
			showFinished();
		}
        //on win
        




    }
    
    //Reloads the Level
    public void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}

	//controls the pausing of the scene
	public void pauseControl(){
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0){
				Time.timeScale = 1;
				hidePaused();
			}
	}

	//shows objects with ShowOnPause tag
	public void showPaused(){
		
			pauseMenu.SetActive(true);
		
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
		pauseMenu.SetActive(false);
		
	}

	//shows objects with ShowOnFinish tag
	public void showFinished(){
		gameOverMenu.SetActive(true);
		
	}

	//hides objects with ShowOnFinish tag
	public void hideFinished(){
		gameOverMenu.SetActive(false);
		
	}
    public void backToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

	
	     public void exitGame() {
     Application.Quit();
     }

}