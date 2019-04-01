using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int defenderCost = 100;

    public void AddResourceToTotal(int amount)
    {
        FindObjectOfType<ResourceDisplay>().AddResource(amount);
    }

    public int GetStarCost()
    {
        return defenderCost;
    }
}
