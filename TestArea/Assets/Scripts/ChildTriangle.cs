using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTriangle : MonoBehaviour {

    // The GridCoords:
    // a,b,c      ->    a: localPosition.Y
    //                  b: localPosition.Z
    GridPos GridCoords;

    public void SetGridCoords(GridPos gridPos)
    {
        GridCoords = gridPos;
        if (gridPos.Z == 0 || gridPos.Z % 2 == 0)
        {
            // Z is EVEN
            if (gridPos.Y == 0 || gridPos.Y % 2 == 0)
            {
                // Y is EVEN
                transform.localPosition = new Vector3(0, GridCoords.Y * 1.732f, GridCoords.Z);
            }
            else
            {
                // Y is ODD
                transform.localPosition = new Vector3(0, (GridCoords.Y + 1) * 1.732f, GridCoords.Z);
                transform.Rotate(Vector3.right, 180f);
            }
        }
        else
        {
            // Z is ODD
            if (gridPos.Y == 0 || gridPos.Y % 2 == 0)
            {
                // Y is EVEN
                transform.localPosition = new Vector3(0, (GridCoords.Y + 1) * 1.732f, GridCoords.Z);
                transform.Rotate(Vector3.right, 180f);
            }
            else
            {
                // Y is ODD
                transform.localPosition = new Vector3(0, GridCoords.Y * 1.732f, GridCoords.Z);
            }
        }
        
      
    }

}
