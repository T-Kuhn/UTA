using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionSetter : MonoBehaviour {

    public Color startVal = Color.red;
    public Color endVal = Color.black;
    public float duration = 1.0F;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.EnableKeyword("_EMISSION");
    }

    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.SetColor("_EmissionColor", Color.Lerp(startVal, endVal, lerp));
        //rend.material.SetFloat("_Emission", lerp);
        Debug.Log(lerp);
    }
}
