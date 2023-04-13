using System.Collections;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    private bool moving;
    private Vector3 pos,pos1;
    public float speed = 0.2f;    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) && !moving)
            StartCoroutine(movepl(Vector3.up));

        if (Input.GetKey(KeyCode.A) && !moving)
            StartCoroutine(movepl(Vector3.left));

        if (Input.GetKey(KeyCode.S) && !moving)
            StartCoroutine(movepl(Vector3.down));

        if (Input.GetKey(KeyCode.D) && !moving)
            StartCoroutine(movepl(Vector3.right));

    }

    private IEnumerator movepl(Vector3 dir)
    {
        moving = true;

        float eltime = 0;

        pos = transform.position;
        pos1 = pos + dir;

        while (eltime < speed)
        {
            transform.position = Vector3.Lerp(pos,pos1, (eltime/speed));
            eltime += Time.deltaTime;
            yield return null;
        }

        transform.position = pos1;
        moving = false; 
    }
}
