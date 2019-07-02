using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour {

    GameObject player;
   

    public GameObject boost;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {


            player.transform.localPosition = new Vector3(0, 20, -95);

            FindObjectOfType<GameSpecialManager>().StartCoroutine(tenSeconds());



        }

    }

    IEnumerator tenSeconds()
    {
        boost.SetActive(false);
        yield return new WaitForSeconds(10);

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
