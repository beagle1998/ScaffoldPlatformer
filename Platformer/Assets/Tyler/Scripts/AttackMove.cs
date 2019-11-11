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
    public float healamount=3f;
    public float maxScale = 1f;

    //transform.right* speed;new Vector2(20, 50)
    void Start()
    {
        rb.velocity = transform.right*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //bounce++;
        EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage_to_enemy);

        }

        //if (collision.gameObject.tag =="ground")
        // {
        //     rb.velocity = new Vector2(rb.velocity.x, 20);
        // }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            if (collision.gameObject.transform.localScale.x <= (maxScale-healamount))
            {
                collision.gameObject.transform.localScale += new Vector3(healamount, healamount);
            }
            else
            {
                collision.gameObject.transform.localScale = new Vector3(maxScale, maxScale);
            }
            PlayerHealth ph1 = collision.gameObject.GetComponent<PlayerHealth>();
            ph1.HealDamage(healamount);

        }
    }


}
