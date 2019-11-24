using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMove2 : MonoBehaviour
{
    // Start is called before the first frame update
    //THIS ATTACK WILL COLLIDE WITH PLAYER

    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage_to_enemy = 1;
    private int bounce = 0;
    public float healamount = 1f;
    public float heal_scale = .1f;
    public float maxScale = 1f;
    public float maxHealth = 5f;


    //transform.right* speed;new Vector2(20, 50)
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //bounce++;
        //Debug.Log(collision.gameObject.tag);  for debugging the tag

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
     heal_scale = maxScale / maxHealth;//about one point of damage equivalent to size

     if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            if (collision.gameObject.transform.localScale.x <= (maxScale - heal_scale))
            {
                collision.gameObject.transform.localScale += new Vector3(heal_scale, heal_scale);
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
