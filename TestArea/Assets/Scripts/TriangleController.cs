using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TriangleController : MonoBehaviour {

    public GameObject ChildTrianglePrefab;

    List<GameObject> childTriangleList = new List<GameObject>();

    // a 1 dimensional array which has vectors which point to all the available positions
    // for a newly spawned childTriangle
    private HashSet<GridPos> availableSpawnPositions = new HashSet<GridPos>();
    private HashSet<GridPos> occupiedSpawnPositions = new HashSet<GridPos>();

    private System.Random random = new System.Random();

    void SpawnChildTriangle(GridPos gridPos)
    {
        GameObject childTriangle = Instantiate(ChildTrianglePrefab) as GameObject;
        childTriangle.transform.parent = transform;

        // Get child's script
        var script = childTriangle.GetComponent<ChildTriangle>();

        script.SetGridCoords(gridPos);
        childTriangleList.Add(childTriangle);
        UpdateAvailableSpawnPositions(gridPos);
    }

    void UpdateAvailableSpawnPositions(GridPos gridPos)
    {
        availableSpawnPositions.Remove(gridPos);
        occupiedSpawnPositions.Add(gridPos);

        GridPos gridPosCandidate = new GridPos(gridPos.Y, gridPos.Z + 1);
        if (!occupiedSpawnPositions.Contains(gridPosCandidate))
        {
            availableSpawnPositions.Add(gridPosCandidate);
        }
        gridPosCandidate = new GridPos(gridPos.Y, gridPos.Z - 1);
        if (!occupiedSpawnPositions.Contains(gridPosCandidate))
        {
            availableSpawnPositions.Add(gridPosCandidate);
        }

        if (((gridPos.Z == 0 || gridPos.Z % 2 == 0) && (gridPos.Y == 0 || gridPos.Y % 2 == 0)) ||
            (!(gridPos.Z == 0 || gridPos.Z % 2 == 0) && !(gridPos.Y == 0 || gridPos.Y % 2 == 0)))
        {
            gridPosCandidate = new GridPos(gridPos.Y - 1, gridPos.Z);
            if (!occupiedSpawnPositions.Contains(gridPosCandidate))
            {
                availableSpawnPositions.Add(gridPosCandidate);
            }
        }
        else
        {
            gridPosCandidate = new GridPos(gridPos.Y + 1, gridPos.Z);
            if (!occupiedSpawnPositions.Contains(gridPosCandidate))
            {
                availableSpawnPositions.Add(gridPosCandidate);
            }
        }
    }

    void SpawnAtRandomPosition()
    {
        SpawnChildTriangle(availableSpawnPositions.ElementAt(random.Next(availableSpawnPositions.Count)));
    }

    IEnumerator Spawner()
    {
        for (;;)
        {
            SpawnAtRandomPosition();
            yield return new WaitForSeconds(.1f);
        }
    }

    void Start ()
	{
        // At first, 0,0 is the only available SpawnPosition
        availableSpawnPositions.Add(new GridPos(0, 0));
        // Spawn a ChildTriangle
        SpawnChildTriangle(new GridPos(0, 0));
        StartCoroutine("Spawner");
	}
	

	void Update ()
	{

	}
}
