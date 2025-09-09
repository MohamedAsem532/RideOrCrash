using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // For scene reload or quit
public class Score_Collision : MonoBehaviour
{
   

    private int count;
    public TextMeshProUGUI scoreText; // to show score in the corner
    
    
    public TextMeshProUGUI TotalScore; // Totalscore gui as in timer script
   
   
    private bool isGameOver = false;
    public GameObject gameOverUI;
    public GameObject TimerUI; // Timer UI
    public GameObject ScoreUI; // Coins Score UI
    public AudioSource CrashSound;

  
    
    public int GetScore()
    {
        return count; // to use it on timer script and get the final score
    }


    
    void Start()
    {
        count = 0;// for score function
        scoreText.text = "Coins: " + count;


    }


    void OnTriggerEnter(Collider other) 
{
        if (other.gameObject.CompareTag("Coin"))
    {
            count++;
            
            other.gameObject.SetActive(false); // to hide coin when collided 
            scoreText.text = "Coins: " + count; //To get a score text when colliding with a coin
          
    }
}




void OnCollisionEnter(Collision collision)
{

    if (collision.gameObject.CompareTag("Barrier")) // decrease score when collided with a barrier
    {
        if (count > 0) count--; // Don't go below zero
        scoreText.text = "Coins: " + count;
        Debug.Log("Hit barrier! Lost 1 coin.");
    }


    else if (collision.gameObject.CompareTag("Obstacle"))
    {
         isGameOver = true;

        // Show a Game Over UI:
         gameOverUI.SetActive(true);
         TimerUI.SetActive(false); //Hide Timer when game is over
         ScoreUI.SetActive(false); //Hide Score when game is over
         TotalScore.text = "Your Score : " + GetScore();
         CrashSound.Play();
         Time.timeScale = 0f;
         Debug.Log("Hit Obstacle! Game Over.");
    }
}
}
