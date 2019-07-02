using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
     public static float score;
   static public int level;
    public Score scoreText;
    public float restartDelay = 2;
    bool gameHasEnded = false;
    public GameObject completeLevelUI;
    public static int playerLives = 3;
    public void Awake()
    {
       
    }
    public int GetLevel(){
        if (SceneManager.GetActiveScene().name == "Level1"){
            return  1;
        }
        if (SceneManager.GetActiveScene().name == "Level2"){
            return 2;
        }
        if (SceneManager.GetActiveScene().name == "Level3")
        {
            return 3;
        }
        else return 0;
    }
    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            FindObjectOfType<Score>().scoreText.enabled = false;
           
            gameHasEnded = true;
            playerLives--;
            Debug.Log(playerLives);
            if (playerLives == 0)
            {
                score = FindObjectOfType<Score>().GetScore(GetLevel());
                FindObjectOfType<leaderboard>().CheckForHighScore(score);
                SceneManager.LoadScene("GameOver");

                playerLives = 3;
             
            }
            else
            {
               
                score = FindObjectOfType<Score>().GetScore(GetLevel());
                Debug.Log(score);
                FindObjectOfType<leaderboard>().CheckForHighScore(score);
                Invoke("Restart", restartDelay);
                FindObjectOfType<Score>().scoreText.enabled = true;
            }
        }

    }

    public int GetLives(){
        return playerLives;
    }

    void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
