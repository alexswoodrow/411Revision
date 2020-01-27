using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "player") {
			Destroy (other.gameObject);
			SceneManager.LoadScene ("fail");
		}
		if (other.gameObject.tag == "satan") {
			Destroy (other.gameObject);
			SceneManager.LoadScene ("level2");
		}
		if (other.gameObject.tag == "build") {
			Destroy (other.gameObject);
		}
	}
}
