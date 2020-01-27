using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end1 : MonoBehaviour {
	public bool begin;
	public float xspeed = 1f;
	public GameObject satanfoot;
	public Rigidbody2D rigid;
	public float thrust;
	// Use this for initialization
	void Start () {
		begin = true;
		rigid = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (begin == true) {
			xspeed = 1f;

		}

		Debug.DrawLine (transform.position, satanfoot.transform.position);
		//draws line on screen between the 2 points

		if (Physics2D.Linecast (transform.position, satanfoot.transform.position)) {

			RaycastHit2D hitPlatform = Physics2D.Linecast (transform.position, satanfoot.transform.position);
			if (hitPlatform != null) {
				if (hitPlatform.collider.tag == "build") {
					Debug.Log ("build");
					rigid.AddForce (transform.up * thrust);
				}
			
			}
		}
		float currentYvelcoity = GetComponent<Rigidbody2D>().velocity.y;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (xspeed, currentYvelcoity);
	}
		

		
	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "player") {
			Destroy (other.gameObject);
			SceneManager.LoadScene ("Fail");
		}
	}

}
