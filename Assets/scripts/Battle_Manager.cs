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
    public bool nextRound = false;
    private KeyCode[] codes = new KeyCode[5];
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

        codes[0] = KeyCode.Alpha1;
        codes[1] = KeyCode.Alpha2;
        codes[2] = KeyCode.Alpha3;
        codes[3] = KeyCode.Alpha4;
        codes[4] = KeyCode.Alpha5;

        Acplayer = player1;


        for (int i =0; i< 5; i++)
        {
            player1.GetComponent<player_characters>().soldiers[i].GetComponent<Player_movement>().code = codes[i];
            player1.GetComponent<player_characters>().soldiers[i] = Instantiate(player1.GetComponent<player_characters>().soldiers[i], spawn[i], Quaternion.identity, player1.transform);
            player1.GetComponent<player_characters>().soldiers[i].GetComponent<Player_movement>().point = player1.GetComponent<player_characters>().soldiers[i].transform;
            //player1.GetComponent<Player1_Attack>().opposers[i] = player2.GetComponent<player_characters>().soldiers[i];
            //player1.GetComponent<player_characters>().soldiers[i].GetComponent<Player_movement>().point = Instantiate(player1.GetComponent<player_characters>().soldiers[i], spawn[i],Quaternion.identity, player1.transform).transform;
            //player1.GetComponent<player_characters>().soldiers[i].GetComponent<Player_movement>().point = player1.GetComponent<player_characters>().soldiers[i].transform;
            //player1.GetComponent<player_characters>().soldiers[i].GetComponent<Player_movement>().code =  codes[i];
        }
        int k = 5;

        for(int j =0; j< 5; j++)
        {
            player2.GetComponent<player_characters>().soldiers[j].GetComponent<Player_movement>().code = codes[j];
            //player2.GetComponent<player_characters>().soldiers[j].GetComponent<Player_movement>().point = player2.GetComponent<player_characters>().soldiers[j].transform;
            player2.GetComponent<player_characters>().soldiers[j] = Instantiate(player2.GetComponent<player_characters>().soldiers[j], spawn[k], Quaternion.identity, player2.transform);
            player2.GetComponent<player_characters>().soldiers[j].GetComponent<Player_movement>().point = player2.GetComponent<player_characters>().soldiers[j].transform;
            //player2.GetComponent<Player1_Attack>().opposers[j] = player1.GetComponent<player_characters>().soldiers[j];
            //player2.GetComponent<player_characters>().soldiers[j].GetComponent<Player_movement>().point = player2.GetComponent<player_characters>().soldiers[j].transform;
            //player2.GetComponent<player_characters>().soldiers[j].GetComponent<Player_movement>().code = codes[j];
            k++;
        }


        foreach (GameObject bos in Acplayer.GetComponent<player_characters>().soldiers)
        {
            bos.GetComponent<Player_movement>().allow = true;
        }

        foreach (GameObject bos in player2.GetComponent<player_characters>().soldiers)
        {
            bos.GetComponent<Player_movement>().allow = false;
        }

        player2txt.SetActive(false);

        foreach (GameObject obj in Acplayer.GetComponent<player_characters>().soldiers)
        {
            obj.GetComponent<Player_movement>().others.Add(player2.GetComponent<player_characters>().soldiers[0]);
            obj.GetComponent<Player_movement>().others.Add(player2.GetComponent<player_characters>().soldiers[1]);
            obj.GetComponent<Player_movement>().others.Add(player2.GetComponent<player_characters>().soldiers[2]);
            obj.GetComponent<Player_movement>().others.Add(player2.GetComponent<player_characters>().soldiers[3]);
            obj.GetComponent<Player_movement>().others.Add(player2.GetComponent<player_characters>().soldiers[4]);
        }

        foreach (GameObject obj in player2.GetComponent<player_characters>().soldiers)
        {
            obj.GetComponent<Player_movement>().others.Add(Acplayer.GetComponent<player_characters>().soldiers[0]);
            obj.GetComponent<Player_movement>().others.Add(Acplayer.GetComponent<player_characters>().soldiers[1]);
            obj.GetComponent<Player_movement>().others.Add(Acplayer.GetComponent<player_characters>().soldiers[2]);
            obj.GetComponent<Player_movement>().others.Add(Acplayer.GetComponent<player_characters>().soldiers[3]);
            obj.GetComponent<Player_movement>().others.Add(Acplayer.GetComponent<player_characters>().soldiers[4]);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (nextRound == true)
        {
            if(Acplayer == player1)
            {
                Acplayer = player2;

                for(int j = 0; j< 5; j++)
                {
                    Acplayer.GetComponent<player_characters>().soldiers[j].GetComponent<Player_movement>().allow = true;
                }

                foreach(GameObject bo in player1.GetComponent<player_characters>().soldiers)
                {
                    bo.GetComponent<Player_movement>().allow = false;
                    bo.GetComponent<Player_movement>().moving = false;
                }

                player2txt.SetActive(true);
                player1txt.SetActive(false);
            }
            else
            {
                Acplayer = player1;
                foreach (GameObject ob in Acplayer.GetComponent<player_characters>().soldiers)
                {
                    ob.GetComponent<Player_movement>().allow = true;
                }

                foreach (GameObject bo in player2.GetComponent<player_characters>().soldiers)
                {
                    bo.GetComponent<Player_movement>().allow = false;
                    bo.GetComponent <Player_movement>().moving = false;
                }

                player1txt.SetActive(true);
                player2txt.SetActive(false);
            }

            nextRound = false;
        }

    }
}
