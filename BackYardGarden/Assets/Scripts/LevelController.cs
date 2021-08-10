using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] GameObject winLable;
    [SerializeField] GameObject loseLable;
    [SerializeField] int waitToLoud = 5;

    private void Start()
    {
        winLable.SetActive(false);
        loseLable.SetActive(false);
    }


    public void AttacerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttacerKiled()
    {
        numberOfAttackers--;
        if  (numberOfAttackers <= 0)
        {
            StartCoroutine (HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        winLable.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToLoud);
        FindObjectOfType<LevelLoader>().LoudNextScene();
    }


    public void HandleLoseCondition()
    {
        loseLable.SetActive(true);
        Time.timeScale = 0;
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpouners();
    }

    private void StopSpouners()
    {
        AttacerSpawner[] spawnerArray = FindObjectsOfType<AttacerSpawner>();
        foreach (AttacerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }


    }

}
