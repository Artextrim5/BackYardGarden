using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttacerSpawner : MonoBehaviour
{

    [SerializeField] Attacker[] attackerPrefabArray;
    bool keepSpawning = true;
    [SerializeField] float minSpownDelay = 1f;
    [SerializeField] float maxSpownDelay = 5f;
    

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (keepSpawning)
        {
            yield return new WaitForSeconds(Random.Range(minSpownDelay, maxSpownDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        keepSpawning = false;
    }

            
    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spown(attackerPrefabArray[attackerIndex]);
    }

    private void Spown (Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform; // спавнит врага как ребенока спавнера
    }

}
