using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

	public Vector3 screenPoint; //Declares a public vector
	private Vector3 offset; //Declares a private vector

	void OnMouseDown() {
		
			screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position); //...when you click on the object...
			new Vector2 (Input.mousePosition.x, Input.mousePosition.y); //...it constantly readjusts its position to it appears to be dragged across the screen

	}

	void OnMouseDrag() {
		
			Vector2 curScreenPoint = new Vector2 (Input.mousePosition.x, Input.mousePosition.y); //...sets the curpoint to the mouse click position...

			Vector2 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint); //redeclares the vector2 curposition
			transform.position = curPosition;// moves the object

	}
}