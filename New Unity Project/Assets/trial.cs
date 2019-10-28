using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trial : MonoBehaviour
{
    GameObject player;
    SpriteRenderer player_sprite;
    string playerName;
    void Awake()
    {
        playerName = "Player";
    }
    // Start is called before the first frame update
    void Start()
    {
        //Find the Player
        player = GameObject.Find(playerName);
        //Get the player's SpriteRenderer component
        player_sprite = player.GetComponent<SpriteRenderer>();
        Debug.Log("hmmm");
    }

    // Update is called once per frame
    void Update()
    {
        //set the player's sprite color to a random value each frame
        player_sprite.color = new Color(
            Random.Range(0f, 1f), //Red
            Random.Range(0f, 1f), //Green
            Random.Range(0f, 1f), //Blue
            1f); //Alpha
    }
}
