using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveCollider : MonoBehaviour
{

    private void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        FindObjectOfType<LivesDisplay>().LoosLives();
        Destroy(otherCollider.gameObject);
    }



}
