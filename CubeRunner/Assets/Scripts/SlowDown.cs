using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour {

    public GameObject cube;


    public GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player){
            FindObjectOfType<PlayerMovement>().forwardForce = 2000f;
         
           FindObjectOfType<GameSpecialManager>().StartCoroutine(tenSeconds());
           
        // player.transform.localScale = new Vector3(1F, 1F, 1F);
         
        }
       
    
    }
    IEnumerator tenSeconds()
    {
        cube.SetActive(false);
        yield return new WaitForSeconds(10);

        FindObjectOfType<PlayerMovement>().forwardForce = 4000f;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
