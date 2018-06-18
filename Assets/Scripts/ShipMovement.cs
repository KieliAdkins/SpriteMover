using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

    // Declaring our variables
    private SpriteRenderer theRenderer;
    private Transform tf;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
        // Load the sprite renderer component 
        theRenderer = gameObject.GetComponent<SpriteRenderer>();

        // Loading the transform component fron the object the code is on
        tf = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        // if statement for spacebar reset
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = Vector3.zero;
        }

        // if statement for up key controlled movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Move up every frame draw by adding 1 to the y axis
            tf.position = tf.position + (Vector3.up * moveSpeed);
        }

        // if statement for down key controlled movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Move down every frame draw by subtracting 1 from the y axis
            tf.position = tf.position + (Vector3.down * moveSpeed);
        }

        // if statement for right key controlled movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Move right every frame draw by adding 1 to the x axis
            tf.position = tf.position + (Vector3.right * moveSpeed);
        }

        // if statement for left key controlled movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Move left every frame draw that the left arrow is held down
            tf.position = tf.position + (Vector3.left * moveSpeed);
        }

        if (Input.GetKey(KeyCode.LeftShift) || (Input.GetKey(KeyCode.RightShift)))
        {
            // if statement for up key controlled movement
            if (Input.GetKey(KeyCode.UpArrow))
            {
                // Move up every frame draw by adding 1 to the y axis
                tf.position = tf.position + Vector3.up;
            }

            // else if statement for down key controlled movement
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                // Move down every frame draw by subtracting 1 from the y axis
                tf.position = tf.position + Vector3.down;
            }

            // else if statement for right key controlled movement
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                // Move right every frame draw by adding 1 to the x axis
                tf.position = tf.position + Vector3.right;
            }

            // else if statement for left key controlled movement
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                // Move left every frame draw that the left arrow is held down
                tf.position = tf.position + Vector3.left;
            }
        }
    
    }
}
