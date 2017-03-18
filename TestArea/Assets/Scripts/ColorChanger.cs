using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color startColor = Color.red;
    public Color endColor = Color.white;
    public float duration = 1.0F;
    public Renderer rend;
    public Shader shad;

	void Start ()
	{
	    rend = GetComponent<Renderer>();

	}
	
	void Update ()
	{
	    float lerp = Mathf.PingPong(Time.time, duration) / duration;
	    rend.material.color = Color.Lerp(startColor, endColor, lerp);
	}
}
