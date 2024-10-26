using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    void Update()
  {
    if (Input.GetKeyDown(KeyCode.F))
    {
      SceneManager.LoadScene("Over");
    }
  }

  public void RestartLevel()
  {
    SceneManager.LoadScene("Level 1");
  }
}
