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
        MovePlayer();
    }

    //Movement function using the arrow keys
    void MovePlayer()
    {
        Vector3 move = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move.y = step;
        }
        else if ((Input.GetKey(KeyCode.DownArrow)))
        {
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
