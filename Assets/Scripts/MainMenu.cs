using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void Play()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // to load the other scene (The game itself)
    Time.timeScale = 1f;
  }
  public void Quit(){
    Application.Quit();
    Debug.Log("Player Has Quit The Game");
  }
}
