using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class leaderboard : MonoBehaviour {

    public Text[] highScores;

    float[] highScoreValues;
	// Use this for initialization
	void Start () {
        highScoreValues = new float[highScores.Length];
        for (int x = 0; x < highScores.Length; x++){
            highScoreValues[x] = PlayerPrefs.GetFloat("highScoreValues" + x);
        }
        DrawScores();
	}
    void SaveScores(){
        for (int x = 0; x < highScores.Length; x++){
            PlayerPrefs.SetFloat("highScoreValues" + x, highScoreValues[x]);
        }
    }

    public void CheckForHighScore(float _value){
        for (int x = 0; x < highScores.Length; x++){
            if (_value > highScoreValues [x]){
                for (int y = highScores.Length - 1; y > x; y--){
                    highScoreValues[y] = highScoreValues[y - 1];

                }
                highScoreValues[x] = _value;
                DrawScores();
                SaveScores();
                break;
            } 
        }
    }
    void DrawScores(){
        for (int x = 0; x < highScores.Length; x++){
            highScores[x].text = highScoreValues[x].ToString();
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
   public void BacktoMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
