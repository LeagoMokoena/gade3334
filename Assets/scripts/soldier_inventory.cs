using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class soldier_inventory : MonoBehaviour
{

    public List<GameObject> characters;
    public Text text;
    public GameObject man; 
    public GameObject stop;
    public int i;
  
    private void Start()
    {
        i = 4;
    }


    private void Update()
    {
       text.text += characters.Count.ToString();
    }

    public void addplayer()
    {
        GameObject nextCharacter = characters[i];
        characters.RemoveAt(i);
        man.GetComponent<Soldier_Manager>().activeplayer.GetComponent<player_characters>().soldiers.Add(nextCharacter);
        i--;
        if(characters.Count == 0) 
        {
            stop.SetActive(false);
        
        }
    }

  
}


