using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class soldier_inventory : MonoBehaviour
{

    public List<GameObject> characters; 
    public GameObject player1; 
    public GameObject player2; 
    public int amount = 0;
    private GameObject activePlayer; 
    public GameObject start;

    public delegate void CharactersAdded(GameObject player);
    public int i = 0;
    public GameObject character1, chararcter2;
  
    private Battle_Manager battle_manager;
    private void Start()
    {
        activePlayer = player1;
        battle_manager = new Battle_Manager();
    }


    private void Update()
    {
       
    }

    public void addplayer()
    {
            GameObject nextCharacter = characters[i];
            characters.RemoveAt(i);
            activePlayer.GetComponent<player_characters>().soldiers.Add(nextCharacter);
            if (activePlayer.GetComponent<player_characters>().soldiers.Count >= 5)
            {

            activePlayer = player2;
                chararcter2.SetActive(true);
                character1.SetActive(false);
                i = 0;

            }
        if(activePlayer == player2 && player2.GetComponent<player_characters>().soldiers.Count >= 5) 
        { 
            start.SetActive(true);
            battle_manager.player1 = activePlayer;
        }
    }

  
}


