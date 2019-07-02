using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEffects : MonoBehaviour {

    public GameObject sphere;

    public PlayerMovement player;
    public GameObject player1;
    bool ChangeCube;
    bool CubeShrunk;
    private void Awake()
    {
        player1 = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnCollisionEnter(Collision other )
    {
        ChangeCube = true;
        sphere.SetActive(false);
        player.transform.localScale = new Vector3(0.3F, 0.3F, 0.3F);
    }

/*   public void OnTriggerExit(Collider other)
    {
        ChangeCube = false;
        sphere.SetActive(false);
        player.transform.localScale = new Vector3(1F, 1F, 1F);
    }*/

    /*public void OnTriggerEnter(Collider other)
    { 

  
        if (other.gameObject == player1){
     
            if (CubeShrunk == false)
           {

                //  sphere.SetActive(false);
                CubeShrunk = true;
           //     player.transform.localScale = new Vector3(0.3F, 0.3F, 0.3F);


            }
             else if (CubeShrunk == true){

                // Debug.Log("Are you hearing me");
                //sphere.SetActive(false);
                // player.transform.localScale = new Vector3(1F, 1F, 1F);
                CubeShrunk = false;
            }
        }
    } */
    /*  public void OnTriggerExit(Collider other)
      {
          if (other.gameObject == player1) {
              if (CubeShrunk == false){
                  Debug.Log("am i getting called");
                  CubeShrunk = true;
              }
              else if (CubeShrunk == true){
                  CubeShrunk = false;
              }
          }
      } */

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	/*void Update () {
        if(CubeShrunk == false){
            sphere.SetActive(false)
        }
	}*/
}
