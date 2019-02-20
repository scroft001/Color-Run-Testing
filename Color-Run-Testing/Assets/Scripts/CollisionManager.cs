using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour {

	
	void OnCollisionEnter2D(Collision2D collisionInfo){
		//if you collided with an enemy
		if(collisionInfo.collider.tag == "Enemy"){
			//restart level
			Debug.Log("Enemy Hit");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
