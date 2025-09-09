using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // For scene reload or quit

public class Timer : MonoBehaviour
{
[SerializeField] TextMeshProUGUI timerText;
[SerializeField] float remainingTime;

 private bool isGameOver = false;
 public GameObject gameOverUI;
 public GameObject TimerUI; // Timer UI
 public GameObject ScoreUI; // Coins Score UI
 public TextMeshProUGUI TotalScore; // Totalscore gui
 public Score_Collision scoreScript; // Reference to score script

 


void Update()
{

if (isGameOver) return;

if (remainingTime > 0){
remainingTime -= Time.deltaTime; //To make time decrease

}
else if (remainingTime < 0)
{
    remainingTime = 0;
    GameOver();
}
    
    int minutes = Mathf.FloorToInt(remainingTime / 60);
    int seconds = Mathf.FloorToInt(remainingTime % 60);
    timerText.text ="Time: "+ string.Format("{0:00}:{1:00}", minutes,seconds);
}


 void GameOver()   // Game stop when timer has finished
    {
        isGameOver = true;

        // Show a Game Over UI:
         gameOverUI.SetActive(true);
         TimerUI.SetActive(false); //Hide Timer when game is over
         ScoreUI.SetActive(false); //Hide Score when game is over

         TotalScore.text = "Your Score : " + scoreScript.GetScore();
         Time.timeScale = 0f;

         Debug.Log("Game Over!");

    }
 
}