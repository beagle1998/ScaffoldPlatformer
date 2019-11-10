using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPJUmp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x,player1.transform.position.y);
    }
}
