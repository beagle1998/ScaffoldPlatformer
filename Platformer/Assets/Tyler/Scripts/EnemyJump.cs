using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    public float moveSpeed;
    public float max_height;
    private Vector3 my_vect1 ;
    private Vector3 base_pos;
    public GameObject gg;
    bool dir;
    // Start is called before the first frame update
    void Start()
    {
        my_vect1 = new Vector2(0f, max_height);
        base_pos = gameObject.transform.position;
        dir = true;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void FixedUpdate()
    {
        Debug.Log("updating");

        if (gg.transform.position.y <= base_pos.y)
        {
            dir = true;
        }
        else if (gg.transform.position.y >= (base_pos + my_vect1).y)
        {
            dir = false;
        }

        if (dir)
        {
            go_up();
        }
        else
        {
            go_down();
        }
            
// gg.transform.position = Vector2.MoveTowards(gg.transform.position,gg.transform.position+my_vect1, moveSpeed * Time.deltaTime);
    }
    private void go_down()
    {
        gg.transform.position = Vector2.MoveTowards(gg.transform.position, base_pos, moveSpeed * Time.deltaTime);
    }
    private void go_up()
    {
        gg.transform.position = Vector2.MoveTowards(gg.transform.position, gg.transform.position+my_vect1, moveSpeed * Time.deltaTime);
    }

}
