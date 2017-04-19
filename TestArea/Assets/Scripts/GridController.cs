using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour {

    public GameObject FishPrefab;
    [SerializeField] private float spacing = 6.0f;
    public float Spacing { get { return spacing; } }
    [SerializeField] private int rows = 4;
    [SerializeField] private int columns = 3;

	void Start () {
        for (int i = 0; i <= columns; i++) {
            for (int k = 0; k <= rows; k++) {
                GameObject GridFish = Instantiate(FishPrefab) as GameObject;
                GridFish.transform.parent = transform;
                // Get child's script
                var script = GridFish.GetComponent<GridFish>();
                script.setParams(i, k, this);
            }
        }



    }
	
	void Update () {
		
	}
}
