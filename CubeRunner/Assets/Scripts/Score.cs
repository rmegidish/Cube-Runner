using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
    public float GetScore(int level){
        if (level == 1)
        {
            return (player.position.z + 95);
        }
        else if (level == 2)
        {
            return (player.position.z + 1095);

        }
        else if(level == 3){
            return (player.position.z + 2095);
        }
        else
            return 3000;
    }
	// Update is called once per frame
	 void Update () {

      //make disappear at 1000
      //fix the scores
        if (SceneManager.GetActiveScene().name == "Level2") {
            scoreText.enabled = true;
            scoreText.text = (player.position.z + 1095).ToString("0");
        }
       
        if (SceneManager.GetActiveScene().name == "Level3") {
            scoreText.enabled = true;
            scoreText.text = (player.position.z + 2095).ToString("0");
        }
      
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            scoreText.text = (player.position.z + 95).ToString("0");
        }

	}
}
