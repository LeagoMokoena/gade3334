using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class stack : MonoBehaviour
{

    //public GameObject characterIconPrefab; // The prefab for the character icons
    public GameObject player; // The player's character inventory

    private void Start()
    {
       
    }

    public void PlaceCharacterOnMap()
    {
        foreach (GameObject character in player.GetComponent<player_characters>().soldiers)
        {
            // Instantiate a new character icon from the prefab
            GameObject characterIcon = Instantiate(character, transform);
            characterIcon.transform.SetParent(this.transform);

            DontDestroyOnLoad(this.gameObject);
            // Set the icon's image to the character's sprite

            // Set up a button click event to place the selected character on the game map
        }
    }
}

