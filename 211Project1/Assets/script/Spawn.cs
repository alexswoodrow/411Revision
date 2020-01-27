using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour {

	//This script can be used for any spawnable objects, buit each one needs it's own script attached to it's own button

	public GameObject Bounce; //Declares public variables we will we be effecting
	public int Spawns;
	public Text Remaining;
	private float SpawnsLeft; //Declares a private float for counting spawns left

	// Update is called once per frame
	void Update () {
		Remaining.text = "" + Spawns; //Updates the public text "Remaining"
	}

	public void OnMouseDown()
	{
		if (Spawns > 0){ //If spawns are greater than 0 and we are in the build phase...
			print ("CLICK"); //...print "CLICK" to the console...
			GameObject newBounce = Instantiate (Bounce); //...instantiate the declared prefab Bounce...
			newBounce.transform.position = transform.position; //...sets the location for the instantiation...
			Spawns--; //...redeclares Spawns minus one
		}
	}
}