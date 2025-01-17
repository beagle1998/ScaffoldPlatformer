﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// GameManager handles game logic that involves interactions between multiple objects in the scene such as Game Over and current checkPoint location
/// </summary>
public class GameManager : MonoBehaviour {

    public GameObject player; //The player GameObject on the scene
    private Transform SpawnPosition; //The location that the player will spawn
    public float player_scale = 1f;
	
    // Use this for initialization
	void Start () {
        
	}
	

    //Updates the spawnPosition
    public void UpdateSpawnPosition(Transform newPosition)
    {
        SpawnPosition = newPosition;
    }

    //Moves the player to the SPawnPosition and Calls playerHealth Healing function
    public void GameOver()
    {
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        StartCoroutine(RestartGame(playerHealth));
    }

    //Restarts Players health and position with a .5 second delay
    IEnumerator RestartGame(PlayerHealth playerHealth)
    {
        yield return new WaitForSeconds(.5f);
        playerHealth.HealDamage(playerHealth.maxHealth);
        player.transform.position = SpawnPosition.position;

        player.transform.localScale = new Vector3(player_scale,player_scale);///aded here

    }
}
