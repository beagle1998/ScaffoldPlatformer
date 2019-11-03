using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 my_vect1 ;
    public Vector3 base_pos;
    public GameObject gg;
    // Start is called before the first frame update
    void Start()
    {
        my_vect1 = new Vector2(0f, 50f);
        base_pos = gameObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void FixedUpdate()
    {
        Debug.Log("updating");
        Debug.Log(base_pos);
        Debug.Log(my_vect1);
      
        gg.transform.position = Vector2.MoveTowards(gg.transform.position,gg.transform.position+my_vect1, moveSpeed * Time.deltaTime);
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
