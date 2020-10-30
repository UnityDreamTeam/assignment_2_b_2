using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Step size")]
    [SerializeField]
    float step = 0.10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    //Movement function using the arrow keys
    private void movePlayer()
    {
        Vector3 move = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move.y = step;
        }
        else if ((Input.GetKey(KeyCode.DownArrow)))
        {
            transform.position -= new Vector3(0, step, 0);
            move.y = -step;
        }
        else if ((Input.GetKey(KeyCode.RightArrow)))
        {
            move.x = step;
        }
        else if ((Input.GetKey(KeyCode.LeftArrow)))
        {
            move.x = -step;
        }

        transform.position += move;
    }
}
