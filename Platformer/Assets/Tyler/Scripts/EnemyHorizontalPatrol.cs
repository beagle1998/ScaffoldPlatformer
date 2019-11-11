using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalPatrol : MonoBehaviour
{
    public float moveSpeed;
    public float max_dist;
    private Vector3 my_vect1;
    private Vector3 base_pos;
    public GameObject gg;
    bool dir;
    // Start is called before the first frame update
    void Start()
    {
        my_vect1 = new Vector2(max_dist, 0f);
        base_pos = gameObject.transform.position;
        dir = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {

        if (gg.transform.position.x <= base_pos.x)
        {
            dir = true;
        }
        else if (gg.transform.position.x >= (base_pos + my_vect1).x)
        {
            dir = false;
        }

        if (dir)
        {
            go_right();
        }
        else
        {
            go_left();
        }

        // gg.transform.position = Vector2.MoveTowards(gg.transform.position,gg.transform.position+my_vect1, moveSpeed * Time.deltaTime);
    }
    private void go_left()
    {
        gg.transform.position = Vector2.MoveTowards(gg.transform.position, base_pos, moveSpeed * Time.deltaTime);
    }
    private void go_right()
    {
        gg.transform.position = Vector2.MoveTowards(gg.transform.position, gg.transform.position + my_vect1, moveSpeed * Time.deltaTime);
    }

}
