using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour {


    GameObject player;
    public GameObject invincible;
    public Material lightpink;
    public Material oldColor;
    public Material newColor;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player){
            Debug.Log(collision.collider.gameObject.name);

              InvokeRepeating("GenerateColor", 0.5f, 0.5f);
            player.GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
            FindObjectOfType<PlayerMovement>().forwardForce = 6000f;
            FindObjectOfType<PlayerCollision>().invincibleIsOn = true;
          //  FindObjectOfType<PlayerCollision>().InvinciblePlayer(collision);
            FindObjectOfType<GameSpecialManager>().StartCoroutine(tenSeconds());



        }

    }
    public void GenerateColor()
    {
        player.GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();

    }
    IEnumerator tenSeconds()
    {
        invincible.SetActive(false);

        yield return new WaitForSeconds(10);
        CancelInvoke();
        player.GetComponent<Renderer>().material = lightpink;
        FindObjectOfType<PlayerMovement>().forwardForce = 4000f;
        //wait more time
        //sound!
        FindObjectOfType<PlayerCollision>().invincibleIsOn = false;
     
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
