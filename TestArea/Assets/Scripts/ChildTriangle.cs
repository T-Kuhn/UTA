using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTriangle : MonoBehaviour {

    // The GridCoords:
    // a,b,c      ->    a: localPosition.Y
    //                  b: localPosition.Z
    //                  c: 0 -> position triangle pointing UP
    //                     1 -> position triangle pointing DOWN
    IntVector3 GridCoords;

    public void SetGridCoords(IntVector3 gridPos)
    {
        GridCoords = gridPos;
        transform.localPosition = new Vector3(0, GridCoords.X, GridCoords.Y * 1.732f);
    }

}
