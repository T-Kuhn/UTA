using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridFish : MonoBehaviour {

    private Vector2 gridPos;
    private GridController gridController;

    public void setParams(int x, int y, GridController parentRef)
    {
        gridController = parentRef;
        gridPos = new Vector2((float)x, (float)y);
        transform.localPosition = gridController.Spacing * (new Vector3((float)x, (float)y, 0));
    }
	
	void Update () {
		
	}
}
