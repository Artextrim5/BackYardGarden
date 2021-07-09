using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    int currentBuildIndex;
    [SerializeField] float loadDelay = 3f;
    [SerializeField] float dethDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentBuildIndex == 0)
        {
            StartCoroutine(LoadSceneDelay());
        }
    }

   
    IEnumerator LoadSceneDelay()
    {
        yield return new WaitForSeconds(loadDelay);
        LoudNextScene();
    }

    public void LoudNextScene()
    {
        SceneManager.LoadScene(currentBuildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

   public void GameOverScene()
    {
        StartCoroutine(LoadDethDelay());
    }

    IEnumerator LoadDethDelay()
    {
        yield return new WaitForSeconds(dethDelay);
        SceneManager.LoadScene(1);
    }

}
