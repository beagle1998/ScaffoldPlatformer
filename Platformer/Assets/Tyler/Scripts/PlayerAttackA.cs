using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackA : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;
    public GameObject player1;
    bool attackMove = false;
    public GameObject attackAPrefab;
    public Transform attackPoint;
    public GameManager gameManager;
    public float damagetaken = 1;
    public float sizechange = .1f;
    void Start()
    {
        controller = GetComponent<CharacterController2D>();

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }   
        
    }

   

    void Shoot()//everytime shoot is called, adjust attacks scale to players?
    {
       // gameObject.transform.localScale -= new Vector3(sizechange, sizechange);
        //gameObject.transform.localScale = player1.gameObject.transform.localScale;

        attackAPrefab.gameObject.transform.localScale=gameObject.transform.localScale/2;
        Instantiate(attackAPrefab,attackPoint.position, attackPoint.rotation);
        
       // if (gameObject.transform.localScale.x <= 1f)
        //{
        PlayerHealth ph1 = player1.GetComponent<PlayerHealth>();
        ph1.TakeDamage(damagetaken);
       // }
    }
    //gameObject.transform.localScale and vector2


}
