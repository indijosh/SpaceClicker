using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
    public int moneyValue;

    // M
    public int moneyMillions;

    // G
    public int moneyBillions;

    // T
    public int moneyTrillions;

    // P
    public int moneyQuadrillion;

    // E
    public int moneyQuintillion;

    // Z
    public int moneySextillion;

    // Y
    public int moneySeptillion;

    Text moneyTextObject;

	// Use this for initialization
	void Start () {
        moneyTextObject = GameObject.Find("MoneyText").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(moneyValue);
        if(moneyValue >= 1000000)
        {
            moneyValue -= 1000000;
            moneyMillions += 1;
        }

        if(moneyMillions >= 1)
        {
            moneyTextObject.text = "$ " + moneyMillions.ToString() + " M";
        }

        else if(moneyMillions < 1)
        {
            moneyTextObject.text = "$ " + moneyValue.ToString();
        }
    }
}
