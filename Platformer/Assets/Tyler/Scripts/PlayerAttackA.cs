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

   

    void Shoot()
    {
        Instantiate(attackAPrefab, attackPoint.position, attackPoint.rotation);
        gameObject.transform.localScale -=  new Vector3(.1f,.1f);
        if (gameObject.transform.localScale.x <= 1f)
        {
            PlayerHealth ph1 = player1.GetComponent<PlayerHealth>();
            ph1.TakeDamage(1);
        }
    }
    //gameObject.transform.localScale and vector2


}
