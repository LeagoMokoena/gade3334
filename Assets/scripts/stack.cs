using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class stack : MonoBehaviour
{

    public GameObject characterIconPrefab; // The prefab for the character icons
    public GameObject player; // The player's character inventory

    private void Start()
    {
        // Loop through each character in the inventory and create an icon for it
        foreach (GameObject character in player.GetComponent<player_characters>().soldiers)
        {
            // Instantiate a new character icon from the prefab
            GameObject characterIcon = Instantiate(characterIconPrefab, transform);

            // Set the icon's image to the character's sprite

            // Set up a button click event to place the selected character on the game map
        }
    }

    private void PlaceCharacterOnMap(Character character)
    {
        // TODO: Implement code to place the selected character on the game map
    }
}

