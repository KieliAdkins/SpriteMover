using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour {

    // Declaring our variables
    public GameObject theObject;
    private ShipMovement myMovement;

    // Use this for initialization
    void Start () {
        myMovement = GetComponent<ShipMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        // if loop for component disabling
		if (Input.GetKeyDown(KeyCode.P))
        {
            myMovement.enabled = !myMovement.enabled; 
        }

        //  if loop for game object disabling 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            theObject.SetActive(false);
        }
    }
}
