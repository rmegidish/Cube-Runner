using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinPower : MonoBehaviour {

    public GameObject sphere;

   
    public GameObject player;
 
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            player.transform.localScale = new Vector3(0.5F, 1F, 1F);


            FindObjectOfType<GameSpecialManager>().StartCoroutine(tenSeconds());

            // player.transform.localScale = new Vector3(1F, 1F, 1F);

        }


    }
    IEnumerator tenSeconds()
    {
        sphere.SetActive(false);
        yield return new WaitForSeconds(10);

        player.transform.localScale = new Vector3(1F, 1F, 1F);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
