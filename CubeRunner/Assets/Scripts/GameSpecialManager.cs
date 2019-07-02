using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpecialManager : MonoBehaviour {


    public GameObject thin;
    public GameObject slowDown;
    public GameObject invincible;

    public GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
   public IEnumerator tenSeconds()
    {
        thin.SetActive(false);
        yield return new WaitForSeconds(10);

        //player.transform.localScale = new Vector3(1F, 1F, 1F);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
