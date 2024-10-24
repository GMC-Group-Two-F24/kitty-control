using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
  public int level;
  public void Level1()
  {
    SceneManager.LoadScene("Level 1");
  }
}
