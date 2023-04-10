using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_characters : MonoBehaviour
{
    public GameObject character;
    public int maxCharacters = 10;  

    private List<GameObject> soldiers = new List<GameObject>();

    public void Add()
    {
        if(soldiers.Count < maxCharacters)
        {
            Debug.Log("max amount of soldiers has been reached");
        }

        GameObject newSoldier = Instantiate(character);

        soldiers.Add(newSoldier);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
