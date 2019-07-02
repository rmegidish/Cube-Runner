using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargePlayer : MonoBehaviour {


    GameObject player;
   public GameObject sphere;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject == player){
          
            sphere.SetActive(false);
            player.transform.localScale = new Vector3(1F, 1F, 1F);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
