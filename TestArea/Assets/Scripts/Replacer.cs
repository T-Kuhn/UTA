using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replacer : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }


    void Update()
    {
        onRails();
    }

    //
    // Summary:
    //     ///
    //     This method should be used for a "on rails" movement
    //     ///
    //
    private void onRails()
    {
        var t = Time.realtimeSinceStartup;
        transform.localPosition = new Vector3(5*Mathf.Sin(t),1,5*Mathf.Cos(t));
    }

    //
    // Summary:
    //     ///
    //     This method should be used for a more unpredictable moving pattern
    //     ///
    //
    private void changingParameters()
    {
        // Here we try to move the body in line to the z direction of the object
        // while rotating it along the y axes of the object
        transform.Rotate(new Vector3(0,100,0) * Time.deltaTime);
        transform.Translate(new Vector3(0, 0, 10) * Time.deltaTime);
        // We expect the thing to move in a horizontal circle

    }

}

// now here's an idea
// we build some kind of checkbox on this script
// in order to decide which of the rotation modes we want to use.
// Another idea:
// Let's try to play that game in a higher resolution.
