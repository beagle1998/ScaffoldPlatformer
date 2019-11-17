using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    // Start is called before the first frame update
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

    }
}



