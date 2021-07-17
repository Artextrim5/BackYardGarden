using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    float currentWalkSpeed = 1f;

        
    void Update()
    {
        transform.Translate(Vector2.left * currentWalkSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentWalkSpeed = speed;
    }

}
