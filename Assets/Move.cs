using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 start;
    public Vector3 end;
    public float speed;
    private bool reverse;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        end += transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != end && !reverse)
        {
            transform.position = Vector3.MoveTowards(transform.position, end, speed * Time.deltaTime);
        }
        else
        {
            reverse = true;
        }

        if (reverse)
        {
            transform.position = Vector3.MoveTowards(transform.position, start, speed * Time.deltaTime);
            if (transform.position == start)
            {
                reverse = false;
            }
        }
    

    }
}
