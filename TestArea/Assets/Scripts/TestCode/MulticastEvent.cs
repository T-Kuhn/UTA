﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class MulticastEvent : MonoBehaviour
{
    public delegate void MyDelegate();
    public delegate void TestDelegate(string str);
    public event MyDelegate Activate;

    public X xobj;
    public Y yobj; 

    public void doSomething(string str)
    {
        Debug.Log(str);
    }
    public void doSomethingelse(string str)
    {
        Debug.Log("something else: " + str);
    }
    public void fire()
    {
        if (Activate != null)
        {
            Activate();
        }
    }

	void Start () {
        xobj = new X();
        yobj = new Y();
        Activate += new MyDelegate(xobj.Xhandler);
        Activate += new MyDelegate(yobj.Yhandler);
        TestDelegate testdel = new TestDelegate(doSomething);
        testdel("string");
        testdel = new TestDelegate(doSomethingelse);
        testdel("string");
        fire();
	}
}



public class X
{
    public void Xhandler()
    {
        Debug.Log("Xhandler got fired!");
    }
}

public class Y
{
    public void Yhandler()
    {
        Debug.Log("Yhandler got fired!");
    }
}

