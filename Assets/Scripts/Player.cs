using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public List<int> diceValues;
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        for(int i = 1; i <= 3; i++)
        {
            diceValues.Add(i);
            diceValues.Add(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
    }
}
