using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class soldier_inventory : MonoBehaviour
{

    public List<GameObject> allCharacters; // A list of all available characters
    public GameObject player1; // Reference to player 1
    public GameObject player2; // Reference to player 2
    public int amount = 0;
    private GameObject activePlayer; // The player who is currently taking a turn
    public GameObject start;
    // Event that is triggered when a player finishes adding characters
    public delegate void CharactersAdded(GameObject player);
    public int i = 0;
    public GameObject character1, chararcter2;
    public GameObject stacke,stake2;
    private void Start()
    {
        activePlayer = player1; // Player 1 starts first

    }

    private void Update()
    {
        /*if (addingCharacters)
        {
            // Allow the active player to add a character to their inventory
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Remove the next character from the allCharacters list and add it to the active player's inventory
                GameObject nextCharacter = allCharacters[0];
                allCharacters.RemoveAt(0);
                activePlayer.GetComponent<player_characters>().soldiers.Add(nextCharacter);
                amount++;
                // If there are no more characters left in the allCharacters list, trigger the CharactersAdded event
                if (amount < 5)
                {
                    // Switch to the other player's turn
                    activePlayer = player2;
                    amount = 0;
                    players++;
                }
            }
        }
        else
        {
            // Perform other game logic here for when players are no longer adding characters
            // For example, you could start a battle or move characters on the game board
        }*/
    }

    public void addplayer()
    {
        // Allow the active player to add a character to their inventory
        // Remove the next character from the allCharacters list and add it to the active player's inventory
            GameObject nextCharacter = allCharacters[i];
            allCharacters.RemoveAt(i);
            activePlayer.GetComponent<player_characters>().soldiers.Add(nextCharacter);
        if (activePlayer == player1)
        {
            i++;
        }
        else
        {
            i--;
        }
            // If there are no more characters left in the allCharacters list, trigger the CharactersAdded event
            if (i >= 5)
            {
            // Switch to the other player's turn
                stacke.GetComponent<stack>().player = activePlayer;
                stacke.GetComponent<stack>().PlaceCharacterOnMap();
                activePlayer = player2;
                chararcter2.SetActive(true);
                character1.SetActive(false);
                i = 4;

            }
        if(activePlayer == player2 && i < 0) 
        {
            stake2.GetComponent<stack>().player = activePlayer;
            stake2.GetComponent<stack>().PlaceCharacterOnMap();
            start.SetActive(true);
        }
    }
}


