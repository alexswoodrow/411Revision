using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementfornow : MonoBehaviour {
	public float xspeed = 1f;
	public GameObject groundcheck;
	public GameObject destroy;
	Vector2 direction; // which way to raycast
	public bool begin;
	public GameObject foot;
	public float jump;
	public Rigidbody2D rig;
	public float balls;


	// Use this for initialization
	void Start () {
		begin = true;
		rig = GetComponent<Rigidbody2D> ();
		balls = 1f;
	}

	// Update is called once per frame
	void Update () {
		if (begin == true) {
			xspeed = 1f;
		}

		float currentYvelcoity = GetComponent<Rigidbody2D>().velocity.y;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (xspeed, currentYvelcoity);

		Debug.DrawLine (transform.position, groundcheck.transform.position);
		//draws line on screen between the 2 points

		if (Physics2D.Linecast (transform.position, groundcheck.transform.position)) {
			
			RaycastHit2D hitPlatform = Physics2D.Linecast (transform.position, groundcheck.transform.position);
			if (hitPlatform != null) {
				if (hitPlatform.collider.name == "go") {
					//Debug.Log ("go");
				}
				if (hitPlatform.collider.tag == "go" && Input.GetMouseButtonUp(0) && balls >= 1) {
					Vector2 newPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
					GameObject ball = Instantiate (destroy);
					ball.transform.position = newPosition;
					Debug.Log ("destroy");
					balls--;
				}
			}
	}
		Debug.DrawLine (transform.position, foot.transform.position);
		//draws line on screen between the 2 points

		if (Physics2D.Linecast (transform.position, foot.transform.position)) {

			RaycastHit2D hitPlatform = Physics2D.Linecast (transform.position, foot.transform.position);
			if (hitPlatform != null) {
				if (hitPlatform.collider.tag == "build") {
					Debug.Log ("build");
					rig.AddForce (transform.up * jump);
				}

			}
		}
}
}