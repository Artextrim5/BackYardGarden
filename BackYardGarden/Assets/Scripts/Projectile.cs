using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] float projectileSpeed = 1f;
    //[SerializeField] float rotationSpeed = 1f;
    [SerializeField] float damage = 50f;




    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
        //transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        var attacer = otherCollider.GetComponent<Attacker>();

       if (attacer && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }

        
    }

}
