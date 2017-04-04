using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memo : MonoBehaviour {

	// Just a memo
    // what are the next steps here?
    // one might be to get the thing to rotate around a fixed point.
    // The next step should be something like this:
    // - we need some kind of flying object thing
    // - the end position is fixed.
    // 
    // there are 2 ways to do this.
    // and I already like the second way better.
    // the second way is all about mathmatical formulas.
    // because we know the end position, it is possible to derive
    // a formula which will turn the thing about it's own axis in such a way that
    // it will be just in the right place when it arrives at the desired position.

    // we need a variable c which will count back from 1 or something like that.
    // when c is 0 the thing needs to be at the desired position.
    // this is for the position (x direction):
    // f(c) = goalpos_x - c^2 * 80.0f

    // we start at _startVal
    // and substract _subVal every frame


}
