using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class playerAudioCtrl : MonoBehaviour
{
    //pitch when speedup:
    static float basePitch = 1.0f;
    
    public float maxPitch = 2.0f;
    public float minPitch = 0.9f;
    public float substraction;
    public GameObject Player;
    private PlayerController playerScript;
    private AudioSource audioSource;

    //Control
    //Play the music
    bool s_Play;

    bool s_Mute = false;
    //Detect when you use the toggle, ensures music isn’t played multiple times
    bool s_ToggleChange;



    void Awake()
    {
        playerScript = Player.GetComponent<PlayerController>();
        audioSource = Player.GetComponent<AudioSource>();
        s_Play = true;
        
    }

    
    
    /*void OnCollisionEnter(Collision collision)
    {
        audio.Play();
        Debug.Log(collision.collider.name);
    }
    */
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
    increasePitchOnSpeedUp(playerScript.acceleration);
        //Check to see if you just set the toggle to positive
        if (s_Play == true && s_ToggleChange == true)
        {
            //Play the audio you attach to the AudioSource component
            audioSource.Play();
            //Ensure audio doesn’t play more than once
            s_ToggleChange = false;
        }
        //Check if you just set the toggle to false
        if (s_Play == false && s_ToggleChange == true)
        {
            //Stop the audio
            audioSource.Stop();
            //Ensure audio doesn’t play more than once
            s_ToggleChange = false;
        }
    }
    void OnGUI()
    {
        //Switch this toggle to activate and deactivate the parent GameObject
        s_Play = GUI.Toggle(new Rect(10, 20, 100, 30), s_Play, "Lightcycle sound");

        //Detect if there is a change with the toggle
        if (GUI.changed)
        {
            //Change to true to show that there was just a change in the toggle state
            s_ToggleChange = true;
        }

    }
    void increasePitchOnSpeedUp(float currentSpeed)
    {
        //substraction = maxPitch - minPitch;
        audioSource.pitch = minPitch + (currentSpeed / 60) * substraction;
        audioSource.volume = (currentSpeed / 60) * substraction;
    }
}
