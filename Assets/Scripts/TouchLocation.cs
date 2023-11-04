using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLocation
{
    public int touchId;
    public GameObject touchGO;

    public TouchLocation(int newTouchId, GameObject newCircle)
    {
        touchId = newTouchId;
        touchGO = newCircle;
    }
}