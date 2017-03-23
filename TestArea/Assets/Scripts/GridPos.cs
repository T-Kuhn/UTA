using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GridPos {

    int y;
    int z;

    public int Y
    {
        get { return y; }
    }
    public int Z
    {
        get { return z; }
    }

    public GridPos(int para1, int para2)
    {
        y = para1;
        z = para2;
    }
}
