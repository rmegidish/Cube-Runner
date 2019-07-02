using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {


    public PlayerMovement movement;
    public bool invincibleIsOn =false;
    public Rigidbody rb;
    public Transform player;
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(invincibleIsOn);

        if (collision.collider.tag == "Obstacle"){
            if (invincibleIsOn == true)
            {

                collision.collider.enabled = false;

            }
            else
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
        
    }

  /*  public void InvinciblePlayer(Collision collision){
    
        if (collision.collider.tag == "Player"){
            Debug.Log("is this ya");
            GameObject.FindGameObjectWithTag("Obstacle").SetActive(false);
        }
    }*/
    public void StopMoving(){
        movement.enabled = false;
    }
}
