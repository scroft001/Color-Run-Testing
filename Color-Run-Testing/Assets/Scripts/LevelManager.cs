using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D info){
		if(info.gameObject.tag == "Player"){
			Debug.Log ("Finished");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}
