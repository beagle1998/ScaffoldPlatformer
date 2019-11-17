using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage_to_enemy=1;
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
        //bounce++;
        Debug.Log(collision.gameObject.tag);
        EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage_to_enemy);

        }

        if (collision.gameObject.tag == "Player")
        {
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
            
            if (collision.gameObject.transform.localScale.x <= .7f)
            {
                collision.gameObject.transform.localScale += new Vector3(.3f, .3f);
            }
            else
            {
                collision.gameObject.transform.localScale = new Vector3(1f, 1f);
            }
            PlayerHealth ph1 = collision.gameObject.GetComponent<PlayerHealth>();
            ph1.HealDamage(3f);

        }

        //if (collision.gameObject.tag =="ground")
        // {
        //     rb.velocity = new Vector2(rb.velocity.x, 20);
        // }
    }


}
