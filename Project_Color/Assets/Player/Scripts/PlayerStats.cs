using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public float playerHealth;
    public int playerAttack;

    public int num1;
    public int num2;

	// Use this for initialization
	void Start () {
        playerHealth = 100;
        playerAttack = 1;
        num1 = 0;
        num2 = 0;
    }
	
	// Update is called once per frame
	void Update () {
        num2 = 4;

        if (Input.GetKeyDown(KeyCode.Q)) { Reset(); num1++; }
            

        if (num1 > num2)
            num1 = 0;

        if (num1 == 0) { DefaultAbility(); } 
        else if (num1 == 1) { RedAbility(); }  
        else if (num1 == 2) { YellowAbility(); }  
        else if (num1 == 3) { GreenAbility(); }
        else if (num1 == 4) { BlueAbility(); }
	}


    void DefaultAbility() { }
    void RedAbility()
    {
        playerAttack = 3;
    }
    void YellowAbility()
    {
        GetComponent<PlayerMovement>().multiplier = 2f;
    }
    void GreenAbility()
    {
        playerHealth+=.2f;
    }
    void BlueAbility()
    {
        if(Input.GetKeyDown(KeyCode.D))
            transform.position = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
        if (Input.GetKeyDown(KeyCode.A))
            transform.position = new Vector3(transform.position.x - 3, transform.position.y, transform.position.z);
    }
    void Reset()
    {
        GetComponent<PlayerMovement>().multiplier = 1f;
        playerAttack = 1;
    }
}
