using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider) // проверяем с чем коллизия
    {
        GameObject othrerObgect = otherCollider.gameObject; // записываем в переменную сам объект с которым произошла коллизия
        Debug.Log(othrerObgect);
        if (othrerObgect.GetComponent<Defender>()) // проверяем есть ли на объекте скрипт Defender
        {
            GetComponent<Attacker>().Attack(othrerObgect); // запускаем свой скрипт Attacker и метод Attack с входным параметром (othrerObgect)
        }
    }


}
