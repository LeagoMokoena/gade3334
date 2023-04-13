using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_characters : MonoBehaviour
{
    public GameObject character;
    public int maxCharacters = 10;
    public List<GameObject> soldiers = new List<GameObject>();
    private int amount = 10;

    public void Add()
    {
        if(soldiers.Count < maxCharacters)
        {
            Debug.Log("max amount of soldiers has been reached");
            return;
        }

        GameObject newSoldier = Instantiate(character);
        soldiers.Add(character);
        amount--;
        
        if(amount <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
