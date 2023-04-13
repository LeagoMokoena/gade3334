using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_Manager : MonoBehaviour
{
    public GameObject player1, player2;
    public GameObject selectedCharacter;
    public List<GameObject> gameObjects;
    private Vector2[] spawn = new Vector2[10];

    // Start is called before the first frame update
    void Start()
    {

        spawn[0] = new Vector2(-80, 30);
        spawn[1] = new Vector2(0, 30);
        spawn[2] = new Vector2(160, 30); 
        spawn[3] = new Vector2(240, 30); 
        spawn[4] = new Vector2(320, 30); 
        spawn[5] = new Vector2(-80, 300); 
        spawn[6] = new Vector2(0, 300); 
        spawn[7] = new Vector2(160, 300); 
        spawn[8] = new Vector2(240, 300); 
        spawn[9] = new Vector2(320, 300);
        /*gameObjects[0].transform.position = new Vector2(-80, 30);
        gameObjects[1].transform.position = new Vector2(0, 30);
        gameObjects[2].transform.position = new Vector2(160, 30);
        gameObjects[3].transform.position = new Vector2(240, 30);
        gameObjects[4].transform.position = new Vector2(320, 30);
        gameObjects[5].transform.position = new Vector2(-80, 300);
        gameObjects[6].transform.position = new Vector2(0, 300);
        gameObjects[7].transform.position = new Vector2(160, 300);
        gameObjects[8].transform.position = new Vector2(240, 300);
        gameObjects[9].transform.position = new Vector2(320, 300);*/

        /*foreach(GameObject ob in gameObjects)
        {
            Instantiate(ob);    
        }*/
        for(int i =0; i< 10; i++)
        {
            Instantiate(gameObjects[i], spawn[i],Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedCharacter != null && Input.GetMouseButtonDown(0))
        {
            selectedCharacter.GetComponent<Player_movement>().speed = 00000000f;
        }
    }
}
