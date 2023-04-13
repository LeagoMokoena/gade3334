using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Attack : MonoBehaviour
{
    public float attackRange; // the range at which the GameObject can attack
    public GameObject attacker;
    public float attackInterval; // the time interval between attacks
    public GameObject enemy; // a list of the second player's GameObjects

    void Start()
    {
        // find all GameObjects with the enemyTag and add them to the enemyList
    }

    void Update()
    {
        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;
        foreach (GameObject enemy in enemy.GetComponent<player_characters>().soldiers) // loop through all enemies in the list
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance < closestDistance) // if the enemy is closer than the current closest enemy
            {
                closestEnemy = enemy;
                closestDistance = distance;
            }
        }

        if (closestEnemy != null && closestDistance <= attackRange) // if there is a close enough enemy to attack
        {
            // do attack logic here, such as subtracting health from the enemy
            closestEnemy.GetComponent<cherteds>().HP += closestEnemy.GetComponent<cherteds>().defense; 
            closestEnemy.GetComponent<cherteds>().HP -= this.GetComponent<cherteds>().attack;
        }
    }
}

