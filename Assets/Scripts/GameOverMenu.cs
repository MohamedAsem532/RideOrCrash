using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
  public void PlayAgain()
  {
    Time.timeScale = 1f; // to make game playable when i press restart because in timer script game over get the timescale to 0 
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex ); // to load same scene

  }
   public void ReturnMainMenu()
  {

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // to load same scene

  }
 
}
