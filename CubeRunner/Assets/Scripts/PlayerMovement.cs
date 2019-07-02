using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public Material startingMaterial;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

   /* public void Awake()
    {
        rb.GetComponent<Renderer>().material = startingMaterial;
    } */
    // Update is called once per frame
    void FixedUpdate () {
        //this means that we add a constant force to the cube
        rb.AddForce(0f, 0f, forwardForce *Time.deltaTime);
      //  rb.transform.localScale = new Vector3(0.3F, 0.3F, 0.3F);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
        }
            if (Input.GetKey("a"))
            {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);

            }

        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
	}
   

}
