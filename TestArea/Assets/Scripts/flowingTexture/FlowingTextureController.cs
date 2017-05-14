using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowingTextureController : MonoBehaviour {

    private Shader shad;
    private Renderer rend;
    private Texture2D allWhiteMaintexture;
    private float offset_X;
    private float offset_Y;

    void Start () {
        shad = GetComponent<Shader>();
        rend = GetComponent<Renderer>();
        MakeMainTextureAllWhite();
        offset_X = 0.0f;
        offset_Y = 0.0f;
    }

	
	void Update () {
        MoveSecondaryTextureOffset();
    }


    void MoveSecondaryTextureOffset()
    {
        offset_X += Time.deltaTime;
        offset_Y += 0.0f; //Time.deltaTime;
        rend.material.SetTextureOffset("_DetailAlbedoMap", new Vector2(offset_X, offset_Y));
    }

    void MakeMainTextureAllWhite()
    {
        var tmpTexture = (Texture2D)rend.material.GetTexture("_MainTex");
        allWhiteMaintexture = new Texture2D(tmpTexture.width, tmpTexture.height);
        var tmpColArr = tmpTexture.GetPixels32();
        for (int i = 0; i < tmpColArr.Length; i++)
        {
            if (tmpColArr[i].a > 0)
            {
                tmpColArr[i].r = 255;
                tmpColArr[i].g = 255;
                tmpColArr[i].b = 255;
            }
        }
        allWhiteMaintexture.SetPixels32(tmpColArr);
        allWhiteMaintexture.Apply();
        rend.material.SetTexture("_MainTex", allWhiteMaintexture);
        rend.material.SetTexture("", allWhiteMaintexture);
    }
}
