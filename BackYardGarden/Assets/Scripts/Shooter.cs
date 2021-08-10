using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile, gun;
    float projectileDamade;
    AttacerSpawner myLineSpowner;
    Animator animator;
    GameObject progectileParent;
    const string PROJECTILE_PARENT_NAME = "Projectiles";


    private void Start()
    {
        SetLineSpawner();
        animator = GetComponent<Animator>();
        CreateProgectileParent();
    }

    private void CreateProgectileParent()
    {
        progectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!progectileParent)
        {
            progectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }

    private void Update()
    {
        if (IsAttackerInLine())
        {
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }
    }

    private void SetLineSpawner()
    {
        AttacerSpawner[] spawners = FindObjectsOfType<AttacerSpawner>();  //Создаем массив spawners в который добавляем все элементы на которых висит скрипт AttacerSpawner

        foreach (AttacerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs( spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);// Mathf.Abs чтобы число было положительным. Mathf.Epsilon сравниваем с минимальным  математическим значением
            if (IsCloseEnough)
            {
                myLineSpowner = spawner;
            }
        }
    }


    private bool IsAttackerInLine()
    {
        if (myLineSpowner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }



    public void Fier(float damage)
    {
        GameObject newProjectile = Instantiate(projectile, gun.transform.position, gun.transform.rotation) as GameObject;
        newProjectile.transform.parent = progectileParent.transform;
        projectileDamade = damage;
    }

    public float GetProjectileDamade()
    {        
        return projectileDamade;
    }



}
