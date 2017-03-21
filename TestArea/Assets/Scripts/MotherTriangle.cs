using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherTriangle : MonoBehaviour {

    public GameObject childTrianglePrefab;

    List<GameObject> childTriangleList = new List<GameObject>();

    // a 1 dimensional array which has vectors which point to all the available positions
    // for a newly spawned childTriangle
    private List<IntVector3> availableSpawnPositions = new List<IntVector3>();

    void SpawnChildTriangle(IntVector3 gridPos)
    {
        GameObject childTriangle = Instantiate(childTrianglePrefab) as GameObject;
        childTriangle.transform.parent = transform;

        // Get child's script
        var script = childTriangle.GetComponent<ChildTriangle>();

        script.SetGridCoords(gridPos);

        if (gridPos.Z == 0) {
            // This will rotate the thing into upper position
            childTriangle.transform.Rotate(new Vector3(180, 0, 0));
        }

        childTriangleList.Add(childTriangle);
    }

    void UpdateAvailableSpawnPositions()
    {
        availableSpawnPositions.Clear();
        // here we could use a foreach loop to look at all the elements in
        // childTriangleGrid
        // 

    }
    

	void Start ()
	{
        // Spawn a ChildTriangle
        SpawnChildTriangle(new IntVector3(8, 8, 1));
        SpawnChildTriangle(new IntVector3(8, 8, 0));
	}
	

	void Update ()
	{

	}
}
