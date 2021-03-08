using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[ExecuteInEditMode]
public class RandomUnitInsideCircle : MonoBehaviour
{
    private void OnEnable()
    {
        // Sets the local position or position to be somewhere inside a circle
        // with radius 5 and the center at zero or local position that relative to the object.
        // Note that assigning a Vector2 to a Vector3 is fine.
        // it will just set the X and Y values.
        transform.Find("Cube").localPosition = Random.insideUnitCircle * 5;
    }

}
