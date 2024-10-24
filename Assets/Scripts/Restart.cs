using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{

    
    void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      Debug.Log("Escape key detected");
      Application.Quit();
    }
  }

  public void RestartLevel()
  {
    SceneManager.LoadScene("Level 1");
  }
}
