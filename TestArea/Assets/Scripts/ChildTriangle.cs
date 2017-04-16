using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTriangle : MonoBehaviour {

    // The GridCoords:
    // a,b,c      ->    a: localPosition.Y
    //                  b: localPosition.Z
    GridPos GridCoords;
    public float distanceToCenter;


    public void SetGridCoords(GridPos gridPos, Quaternion q)
    {
        GridCoords = gridPos;
        EmissionSetter es = GetComponent<EmissionSetter>();
        UVMapper uvm = GetComponent<UVMapper>();
        if (((gridPos.Z == 0 || gridPos.Z%2 == 0) && (gridPos.Y == 0 || gridPos.Y%2 == 0)) ||
            !((gridPos.Z == 0 || gridPos.Z%2 == 0) || (gridPos.Y == 0 || gridPos.Y%2 == 0)))
        {
            // Pointing UP
            transform.localPosition = new Vector3(0, GridCoords.Y*1.732f, GridCoords.Z);
            transform.localRotation = Quaternion.identity;
            transform.Rotate(Vector3.right, -270f);
            var tmp = transform.localPosition + new Vector3(0, 0.577f, 0);
            distanceToCenter = Vector3.Distance(tmp, Vector3.zero);
            // UV
            if (uvm != null)
                uvm.SetupParams(transform.localPosition, true);
        }
        else
        {
            // Pointing DOWN
            transform.localPosition = new Vector3(0, (GridCoords.Y + 1) * 1.732f, GridCoords.Z);
            transform.localRotation = Quaternion.identity;
            transform.Rotate(Vector3.right, -90f);
            var tmp = transform.localPosition - new Vector3(0, 0.577f, 0);
            distanceToCenter = Vector3.Distance(tmp, Vector3.zero);
            // UV
            if (uvm != null) { 
                uvm.SetupParams(transform.localPosition, false);
            }
        }
        if (es != null) {
            es.phase = -distanceToCenter / 10.0f;
        }
    }

}
