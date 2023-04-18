using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soldier_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject start;
    public GameObject player1, player2;
    public soldier_inventory inventory;
    public GameObject pl1,pl2;
    public GameObject activeplayer;
    void Start()
    {
        player1 = GameObject.FindWithTag("Player1");
        player2 = GameObject.FindWithTag("Player2");
        activeplayer = player1;
    }

    // Update is called once per frame
    void Update()
    {
        if(player1.GetComponent<player_characters>().recruite == true) 
        {
            pl1.SetActive(false); 
            pl2.SetActive(true);
            activeplayer = player2;
        
        }

        if(player1.GetComponent<player_characters>().recruite == true && player2.GetComponent<player_characters>().recruite == true) 
        {
            start.SetActive(true);
        }
    }
}
