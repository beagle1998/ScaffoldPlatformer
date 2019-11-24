using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public Text life_text;
    public float maxHp = 5f, HP = 5f;
    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        PlayerHealth player_hp = player.GetComponent<PlayerHealth>();
        HP = player_hp.currentHealth;
        life_text.text =HP.ToString() + "/" + maxHp.ToString();
    }

}
