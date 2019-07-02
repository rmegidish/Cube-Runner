using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

   public void StartButton(){
        SceneManager.LoadScene("Level1");

    }

    public void OptionsButton(){
        SceneManager.LoadScene("OptionsMenu");
    }
    public void Quit(){
        Application.Quit();
    }
    public void LeaderboardButton(){
        SceneManager.LoadScene("Leaderboard");
    }
}
