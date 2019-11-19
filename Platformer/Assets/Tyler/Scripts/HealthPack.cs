using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthPack : MonoBehaviour
{
    // Start is called before the first frame update
    public float heal = 1f;
    public float maxScale = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            if (collision.gameObject.transform.localScale.x <= (maxScale - heal/10))
            {
                collision.gameObject.transform.localScale += new Vector3(heal/10, heal/10);
            }
            else
            {
                collision.gameObject.transform.localScale = new Vector3(maxScale, maxScale);
            }
            PlayerHealth ph1 = collision.gameObject.GetComponent<PlayerHealth>();
            ph1.HealDamage(heal);


        }

    }
}



