using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVMapping : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector2[] uvs = new Vector2[vertices.Length];

        for (int i = 0; i < uvs.Length; i++)
        {
            uvs[i] = new Vector2(vertices[i].x, vertices[i].z);
        }
        mesh.uv = uvs;
        // what did we figure out here?
        // we now know, that the line above has some serious effects on the way
        // the texture is applied to the triangle.
    }
}