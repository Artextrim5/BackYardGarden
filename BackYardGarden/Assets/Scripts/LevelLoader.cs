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

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Level 1");
    }
    
    public void LoudMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }
    
    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentBuildIndex);
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

    public void LoadYouLose()
    {
        StartCoroutine(LoadLoseYou());
    }

    IEnumerator LoadLoseYou()
    {
        yield return new WaitForSeconds(loadDelay);
        SceneManager.LoadScene("Lose Screen");
    }

    public void LoadOptionsScene()
    {
        SceneManager.LoadScene("Options");
    }

}
