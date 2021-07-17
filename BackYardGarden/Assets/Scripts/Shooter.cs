using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile, gun;
    float projectileDamade;


    public void Fier(float damage)
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
        projectileDamade = damage;
    }

    public float GetProjectileDamade()
    {        
        return projectileDamade;
    }

}
