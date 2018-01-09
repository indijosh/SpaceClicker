using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceCube : MonoBehaviour {

    PlayerStats playerStats;

    public string resourceType = "stone";

    // Use this for initialization
    void Start()
    {
        GameObject thePlayer = GameObject.Find("PlayerStats");
        playerStats = thePlayer.GetComponent<PlayerStats>();
    }

    void OnMouseDown()
    {
        if (resourceType == "stone")
        {
            playerStats.moneyValue += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
