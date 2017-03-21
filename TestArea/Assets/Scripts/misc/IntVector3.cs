using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public struct IntVector3
{
    int x;
    int y;
    int z;

    public int X
    {
        get { return x; }
    }
    public int Y
    {
        get { return y; }
    }
    public int Z
    {
        get { return z; }
    }

    public IntVector3(int para1, int para2, int para3)
    {
        x = para1;
        y = para2;
        z = para3;
    }
}
