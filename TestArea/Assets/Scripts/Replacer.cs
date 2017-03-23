using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replacer : MonoBehaviour
{

    public GameObject CenterOfMovement;
    [SerializeField] public float yDistance = 5.0f;
    [SerializeField] public float zDistance = 5.0f;

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
        transform.localPosition = new Vector3(1, yDistance * Mathf.Sin(t), zDistance * Mathf.Cos(t)) + CenterOfMovement.transform.position;
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

