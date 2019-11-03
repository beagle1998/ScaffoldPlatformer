using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public Rigidbody2D rb;
    private int bounce = 0;

    //transform.right* speed;new Vector2(20, 50)
    void Start()
    {
        rb.velocity = transform.right*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //void OnTriggerEnter2D(Collider2D hitinfo)
    //{
    //    EnemyHealth enemy = hitinfo.GetComponent<EnemyHealth>();
    //    if (enemy != null)
    //    {
    //        enemy.TakeDamage(1);
    //        bounce++;
    //    }
    //    if (bounce >= 2)
    //    {
    //        Destroy(gameObject);
    //    }
       
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bounce++;
        EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(1);
            
        }
        if (collision.gameObject.tag =="ground")
        {
            rb.velocity = new Vector2(rb.velocity.x, 20);
        }
        if (bounce >= 2)
        {
            Destroy(gameObject);
        }
        
    }


}
