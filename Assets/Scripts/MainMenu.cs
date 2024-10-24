using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
  {
    Debug.Log("Loading level select");
    SceneManager.LoadScene("LevelSelect");
  }

  public void QuitGame()
  {
    Debug.Log("QUIT!");
    Application.Quit();
  }
}
