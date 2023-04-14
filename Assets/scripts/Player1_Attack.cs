using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1_Attack : MonoBehaviour
{

    public string enemyTag; // the tag of the second player's GameObjects
    public float attackRange; // the range at which the GameObject can attack
    public GameObject attacker;
    public float attackInterval; // the time interval between attacks
    private float nextAttackTime; // the time of the next allowed attack
    private List<GameObject> enemyList; // a list of the second player's GameObjects
    public int HPNUM,attacknum,defencenum;
    public Text HP,attack,defence;
    public Vector2 pos = new Vector2();
    public GameObject player1, player2;
    void Start()
    {
        HP.text = HP.text + HPNUM;
        attack.text = attack.text + attacknum.ToString();
        defence.text = defence.text + defencenum.ToString();
        player1 = GameObject.FindWithTag("Player1");
        player2 = GameObject.FindWithTag("Player2");
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {


        }
  
    }
}

