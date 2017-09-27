using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Like Update but used with physics. 
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Debug.Log("H=" + moveHorizontal + " V=" + moveVertical);

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Debug.Log(movement);

        this.GetComponent<Rigidbody2D>().velocity = movement * speed;
    }
}
