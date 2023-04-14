using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_characters : MonoBehaviour
{
    public GameObject character;
    public List<GameObject> soldiers = new List<GameObject>();


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
