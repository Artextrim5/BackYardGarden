using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttacerSpawner : MonoBehaviour
{

    [SerializeField] GameObject enemyToSpown;
    [SerializeField] bool keepSpawning = true;
    [SerializeField] float minSpownDelay = 1f;
    [SerializeField] float maxSpownDelay = 5f;
    

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (keepSpawning)
        {
            yield return new WaitForSeconds(Random.Range(minSpownDelay, maxSpownDelay));
            SpawnAnAnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
    private void SpawnAnAnemy()
    {
        Instantiate(enemyToSpown, transform.position, transform.rotation);
    }

}
