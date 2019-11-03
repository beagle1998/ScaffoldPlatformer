using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackA : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;
    bool attackMove = false;
    public GameObject attackAPrefab;
    public Transform attackPoint;

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
    }
    //gameObject.transform.localScale and vector2


}
