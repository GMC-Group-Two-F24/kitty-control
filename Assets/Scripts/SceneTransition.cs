using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransition : MonoBehaviour
{
  public string scene;
  void Start()
  {
    StartCoroutine(Transition());
  }
  public IEnumerator Transition()
  {

    yield return new WaitForSeconds(5);
    SceneManager.LoadScene(scene);
  }
}
