using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour {
    //should always start at 3
    public Text lives;
    public GameManager playerLives;

    private void Update()
    {
        lives.text = "Lives: " + FindObjectOfType<GameManager>().GetLives().ToString();

    }
}
