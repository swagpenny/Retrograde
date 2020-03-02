using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    //player's variables
    public GameObject player;
    //Player playerScript;
    string diceType;
    int diceSides;
    List<int> diceValues;   //list of dice face values

    //enemy's variables
    public GameObject manager;
    Manager managerScript;


    // Start is called before the first frame update
    void Start()
    {
        //playerScript = player.GetComponent<Player>();
        //diceType = playerScript.diceType;
        //diceSides = playerScript.diceSides;
        //diceValues = playerScript.diceValues;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int RollDiceIndex()
    {
        return Random.Range(0, diceSides); //returns the index between 0 to amount of dice sides
    }

    void TakeDamage(int damageAmount)
    {
        //playerScript.health -= damageAmount;
    }
}
