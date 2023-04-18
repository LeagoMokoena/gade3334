using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_characters : MonoBehaviour
{
    public GameObject character;
    public List<GameObject> soldiers = new List<GameObject>();
    public bool recruite = false;   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(soldiers.Count == 5)
        {
            recruite = true;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
