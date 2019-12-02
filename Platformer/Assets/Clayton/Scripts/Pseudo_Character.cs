using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pseudo_Character : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform Ground_Check;
    public GameObject player1;
    public GameObject snail;
    private float old_y_position;

    void Start()
    {
        old_y_position = snail.transform.position.y;
    }

    private void FixedUpdate()
    {
        
        if (player1.transform.position.y <= (snail.transform.position.y + 0.5f) & player1.transform.position.y >= old_y_position)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, player1.transform.position.y);
        }
        else
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, old_y_position);
        }
        
    }
}
