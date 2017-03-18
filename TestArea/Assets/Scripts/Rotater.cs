using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {
    // The Rotater Script.
    // This Scripts mere purpose is to rotate the transform of the
    // non rigidbody gameobject it is attached to.

	void Start () {
		// inside here we need to think about wether or not
        // there is something we need to set up.
	}
	
	void Update () {
		// inside here the ratating will take place
	    // since we are not using forces we can use Update rather than fixedUpdate
        
        // here we are doing the rotating
        transform.Rotate(new Vector3(15, 30, 45)* Time.deltaTime);
	}
}
