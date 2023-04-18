using System.Collections;
using UnityEngine;
using UnityEngine.Lumin;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Player_movement : MonoBehaviour
{
    public bool moving = false;
    private Vector3 pos,pos1;
    public float speed = 5f;
    public KeyCode code;
    public Text but;
    public Transform point;
    private Transform curre;
    public float dis;
    /*public TileBase ti;
    public Tilemap map;*/

    private void Start()
    {
        pos1 = transform.position;
        point.parent = null;
    }
    private void Update()
    {
        //but.text = code.ToString() + " hold to move";

        if (Vector3.Distance(transform.position,point.position) <= dis)
        {
            transform.position = Vector3.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
        }

        if(Vector3.Distance(transform.position,pos1) <= dis)
        {
            if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                point.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }

            if(Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                point.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
            }
        }
        else
        {
            moving = true;
        }

        
        /*if (Input.GetKey(code))
        {
            if (Input.GetKey(KeyCode.W) && !moving)
                StartCoroutine(movepl(Vector3.up));

            if (Input.GetKey(KeyCode.A) && !moving)
                StartCoroutine(movepl(Vector3.left));

            if (Input.GetKey(KeyCode.S) && !moving)
                StartCoroutine(movepl(Vector3.down));

            if (Input.GetKey(KeyCode.D) && !moving)
                StartCoroutine(movepl(Vector3.right));
        }*/

    }

    /*private void LateUpdate()
    {
        Vector3Int curr = map.WorldToCell(transform.position);

        if(!map.HasTile(curr) || map.GetTile(curr) != ti)
        {
            transform.position = pos1;
        }
        else
        {
            pos1 = transform.position;
        }
    }*/

    /*private IEnumerator movepl(Vector3 des)
    {
        moving = true;

        float ele = 0;

        pos = transform.position;
        pos1 = pos + des;

        while (ele < speed)
        {
            transform.position = Vector3.Lerp(pos,pos1, (ele /speed));
            ele += Time.deltaTime;
            yield return null;
        }

        transform.position = pos1;
        moving = false; 

        
    }*/
}
