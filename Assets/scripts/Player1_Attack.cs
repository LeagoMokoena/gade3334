using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1_Attack : MonoBehaviour
{
    public List<GameObject> opposers; 
    public int HPNUM,attacknum,defencenum;
    public Text HP,attack,defence;
    public GameObject attacker;

    void Start()
    {
        HP.text = HP.text + HPNUM;
        attack.text = attack.text + attacknum.ToString();
        defence.text = defence.text + defencenum.ToString();
        opposers = new List<GameObject>();
    }

    void Update()
    {
        /*if(Input.GetKeyUp(KeyCode.Space))
        {
            for (int i = 0; i < opposers.Count; i++)
            {
                if (Vector3.Distance(transform.position, opposers[0].transform.position) < 5)
                {
                    opposers[i].GetComponent<Player1_Attack>().HPNUM -= this.attacknum;
                }
            }

        }

        foreach(GameObject o in opposers)
        {
            if(o.GetComponent<Player1_Attack>().HPNUM <= 0)
            {
                Destroy(o);
            }    
        }*/
  
    }
}

