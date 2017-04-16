using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVMapper : MonoBehaviour
{
    [SerializeField] private Vector3 localPos;
    [SerializeField] private bool pointingUp;
    [SerializeField] private float devider;

    void Start()
    {
        devider = 50f;
    }

    public void SetupParams(Vector3 lpos, bool pUp)
    {
        devider = 50f;
        pointingUp = pUp;
        localPos = lpos;
        UpdateUVs();
    }

    void UpdateUVs()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector2[] uvs = new Vector2[vertices.Length];

        if (pointingUp) { 
            // front
            uvs[7] = new Vector2(0.5f + (0.0f + localPos.z) / devider, 0.5f + (1.732f + localPos.y) / devider);
            uvs[8] = new Vector2(0.5f + (-1.0f + localPos.z) / devider, 0.5f + (0.0f + localPos.y) / devider);
            uvs[9] = new Vector2(0.5f + (1.0f + localPos.z) / devider, 0.5f + (0.0f + localPos.y) / devider);

            // back
            uvs[0] = new Vector2(0.5f + (0.0f + localPos.z) / devider, 0.5f + (1.732f + localPos.y) / devider);
            uvs[2] = new Vector2(0.5f + (-1.0f + localPos.z) / devider, 0.5f + (0.0f + localPos.y) / devider);
            uvs[1] = new Vector2(0.5f + (1.0f + localPos.z) / devider, 0.5f + (0.0f + localPos.y) / devider);
        } else {
            // front
            uvs[7] = new Vector2(0.5f + (0.0f + localPos.z) / devider, 0.5f + (-1.732f + localPos.y) / devider);
            uvs[9] = new Vector2(0.5f + (-1.0f + localPos.z) / devider, 0.5f + (0.0f + localPos.y) / devider);
            uvs[8] = new Vector2(0.5f + (1.0f + localPos.z) / devider, 0.5f + (0.0f + localPos.y) / devider);

            // back
            uvs[0] = new Vector2(0.5f + (0.0f + localPos.z) / devider, 0.5f + (-1.732f + localPos.y) / devider);
            uvs[1] = new Vector2(0.5f + (-1.0f + localPos.z) / devider, 0.5f + (0.0f + localPos.y) / devider);
            uvs[2] = new Vector2(0.5f + (1.0f + localPos.z) / devider, 0.5f + (0.0f + localPos.y) / devider);
        }

        mesh.uv = uvs;
        // what did we figure out here?
        // we now know, that the line above has some serious effects on the way
        // the texture is applied to the triangle.
    }
}