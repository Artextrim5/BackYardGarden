using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] int starCost = 100;

    public void AddNewStars(int amount) 
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);        
    }

    public int GetStarCost()
    {
        return starCost;
    }
}
