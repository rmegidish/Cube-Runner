using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public PlayerCollision movement;
    public GameManager gameManager;

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<PlayerCollision>().StopMoving();
            gameManager.CompleteLevel();


        }
    }
}
