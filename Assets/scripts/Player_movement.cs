using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Lumin;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Player_movement : MonoBehaviour
{
    public bool moving = false;
    public bool allow = false; 
    private Vector3 pos1;
    public float speed = 5f;
    public KeyCode code;
    public Text but;
    public Transform point;
    public float dis;
    public GameObject manager;
    public List<GameObject> others = new List<GameObject>(5);
    /*public TileBase ti;
    public Tilemap map;*/

    private void Start()
    {
        pos1 = transform.position;
        manager = GameObject.FindWithTag("manager");
        //point.parent = null;
    }
    private void Update()
    {
        //but.text = code.ToString() + " hold to move";
        if(allow == true && Input.GetKey(code))
        {
            if (Vector3.Distance(transform.position, point.position) <= dis)
            {
                transform.position = Vector3.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
            }

            if (Vector3.Distance(transform.position, pos1) <= dis)
            {
                if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
                {
                    point.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }

                if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
                {
                    point.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
            else
            {
                moving = true;
                manager.GetComponent<Battle_Manager>().nextRound = true;
            }
        }

        if(Input.GetKey(KeyCode.Space))
        {
            for (int i = 0; i < others.Count; i++)
            {
                if (Vector3.Distance(transform.position, others[i].transform.position) < 10)
                {
                    others[i].GetComponent<Player1_Attack>().HPNUM -= 2;
                }
            }
        }

    }
}
