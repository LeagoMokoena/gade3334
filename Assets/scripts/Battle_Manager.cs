using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle_Manager : MonoBehaviour
{
    public GameObject player1, player2;
    public GameObject Acplayer;
    public List<GameObject> gameObjects = new List<GameObject>();
    private Vector2[] spawn = new Vector2[10];
    private float time = 5;
    public Text timer;
    public GameObject player1txt, player2txt;
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindWithTag("Player1");
        player2 = GameObject.FindWithTag("Player2");
        spawn[0] = new Vector2(-80, 30);
        spawn[1] = new Vector2(160, 30);
        spawn[2] = new Vector2(400, 30); 
        spawn[3] = new Vector2(640, 30); 
        spawn[4] = new Vector2(880, 30); 
        spawn[5] = new Vector2(-80, 300); 
        spawn[6] = new Vector2(160, 300); 
        spawn[7] = new Vector2(400, 300); 
        spawn[8] = new Vector2(640, 300); 
        spawn[9] = new Vector2(880, 300);
        for(int i =0; i< 5; i++)
        {
            Instantiate(player1.GetComponent<player_characters>().soldiers[i], spawn[i],Quaternion.identity, player1.transform);
            gameObjects.Add(player1.GetComponent<player_characters>().soldiers[i]);
            player1.GetComponent<player_characters>().soldiers[i].GetComponent<Player1_Attack>().pos = spawn[i];

        }
        int k = 5;

        for(int j =0; j< 5; j++)
        {
            Instantiate(player2.GetComponent<player_characters>().soldiers[j], spawn[k], Quaternion.identity, player2.transform);
            k++;
        }
        player2txt.SetActive(false);
        player2.SetActive(false);
        Acplayer = player1;

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = time.ToString();
        
        foreach

        if (time <= 0)
        {
            
            time = 5;
            if(Acplayer == player1)
            {
                Acplayer.SetActive(false);
                Acplayer = player2;
                player2txt.SetActive(true);
                player1txt.SetActive(false);
                Acplayer.SetActive(true);
            }
            else
            {
                Acplayer.SetActive(false);
                Acplayer = player1;
                player1txt.SetActive(true);
                player2txt.SetActive(false);
                Acplayer.SetActive(true);
            }
            
        }
    }
}
