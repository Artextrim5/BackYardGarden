using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider) // проверяем с чем коллизия
    {
        GameObject othrerObgect = otherCollider.gameObject; // записываем в переменную сам объект с которым произошла коллизия

        if (othrerObgect.GetComponent<Grave>())
        {
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }

        Debug.Log(othrerObgect);
        if (othrerObgect.GetComponent<Defender>()) // проверяем есть ли на объекте скрипт Defender
        {
            if (!othrerObgect.GetComponent<Grave>())
            {
                GetComponent<Attacker>().Attack(othrerObgect); // запускаем свой скрипт Attacker и метод Attack с входным параметром (othrerObgect)
            }
        }
    }



}
