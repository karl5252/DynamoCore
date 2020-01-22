using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleItem : MonoBehaviour
{

    [SerializeField]
    private int collectibleID;
    private GameObject PlayerController;
    private GameObject Rigidbody;
    // Start is called before the first frame update
    

    // Update is called once per frame
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.name);
        //handle to the component
        if (other.tag == "Player")
        {
            //access the player
            PlayerController player = other.GetComponent<PlayerController>();
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (player != null)
            {
                ///0 add points
                ///1 add life
                ///2 destroy
                ///3 speed up
                ///4 extend time
                ///5 jump
                ///6 finish
                switch (collectibleID)
                {
                    case 0:
                        player.counter++;
                        break;
                    case 1:
                        player.lCounter++;
                        break;
                    case 2:
                        player.lCounter --;
                        player.transform.position = player.startPosition;

                        break;
                    case 3:
                        player.SpeedModifier();
                        break;
                    case 4:
                        player.timerIncrease = true;
                        break;
                    case 5:
                        rb.velocity = new Vector3(0, 10, 0) * player.jumpHeight; 
                        break;
                    case 6:
                        player.winner = true;
                        break;
                }
                


                



            }
            if (collectibleID == 0 || collectibleID == 1 || collectibleID == 4)
            {
                Destroy(this.gameObject);
            }
            //destroy element

        }

    }
}









