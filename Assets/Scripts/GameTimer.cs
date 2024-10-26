using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameTimer : MonoBehaviour 
{
  public float timeLeft = 60;
  private bool timerRunning = false;
  public TMP_Text Timer;

  void Start()
  {
    Debug.Log("Timer started!");
    timerRunning = true;
  }

  void Update()
  {
    if (timerRunning)
    {
      Debug.Log("Timer is running");
      timeLeft -= Time.deltaTime;

      if (timeLeft <= 0)
      {
        timeLeft = 0;
        timerRunning = false;
        SceneManager.LoadScene("GameOver");
      }
      DisplayTime(timeLeft);
    }
  }

  void DisplayTime(float time)
  {
    float minutes = Mathf.FloorToInt(time / 60);
    float seconds = Mathf.FloorToInt(time % 60);
    Timer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
  }
}
