using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	//variables
	private Vector3 mousePosition;
	public Rigidbody2D rb;
	private Vector2 direction;
	private float moveSpeed = 30f;

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}

	
	// Update is called once per frame
	void Update () {
		//if the mouse is held down (touching the screen)
		if(Input.GetMouseButton(0)){
			//find the mouses position
			mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//set the direction to be that of the mouse
			direction = (mousePosition - transform.position).normalized;
			//move the dot
			rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
		}
		else{
			rb.velocity = Vector2.zero;
		}
	}
}
