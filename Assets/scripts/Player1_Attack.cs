using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Attack : MonoBehaviour
{

    public string enemyTag; // the tag of the second player's GameObjects
    public float attackRange; // the range at which the GameObject can attack
    public GameObject attacker;
    public float attackInterval; // the time interval between attacks
    private float nextAttackTime; // the time of the next allowed attack
    private List<GameObject> enemyList; // a list of the second player's GameObjects

    void Start()
    {
        enemyList = attacker.GetComponent<player_characters>().soldiers;
        // find all GameObjects with the enemyTag and add them to the enemyList
    }

    void Update()
    {
        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;
        foreach (GameObject enemy in enemyList) // loop through all enemies in the list
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

