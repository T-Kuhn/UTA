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

        for (int i = 3; i < uvs.Length; i++)
        {
            uvs[i] = new Vector2(vertices[i].x, vertices[i].z);
        }

        uvs[7] = new Vector2(0.5f, 1.0f);
        uvs[9] = new Vector2(0.0f, 0.0f);
        uvs[8] = new Vector2(1.0f, 0.0f);

        uvs[0] = new Vector2(0.5f, 0.0f);
        uvs[1] = new Vector2(0.0f, 1.0f);
        uvs[2] = new Vector2(1.0f, 1.0f);



        mesh.uv = uvs;
        // what did we figure out here?
        // we now know, that the line above has some serious effects on the way
        // the texture is applied to the triangle.
    }
}