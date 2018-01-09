using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBehavior : MonoBehaviour {

    PlayerStats playerStats;

    public GameObject drone;
    private bool droneSpawned;

	void Start () {
        //Find the PlayerStats GameObject and get the attached PlayerStats script
        GameObject thePlayer = GameObject.Find("PlayerStats");
        playerStats = thePlayer.GetComponent<PlayerStats>();

        //Set drone to not spawned
        droneSpawned = false;
    }
	


	void BuyDrone () {
        if (!droneSpawned)
        {

        }
	}
}
