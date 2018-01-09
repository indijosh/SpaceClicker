using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSite : MonoBehaviour {
    PlayerStats playerStats;

    // Use this for initialization
    void Start () {
        GameObject thePlayer = GameObject.Find("PlayerStats");
        playerStats = thePlayer.GetComponent<PlayerStats>();
	}

    void OnMouseDown()
    {
        playerStats.moneyValue += 100000;
    }

    // Update is called once per frame
    void Update () {
    }
}
