using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomColorHSV : MonoBehaviour
{
    /*private void OnGUI()
    {
        if (GUI.Button(new Rect(20, 20, 100, 50), "random Mat"))
        {
            transform.Find("Cylinder").GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }*/
    
    private void OnMouseDown()
    {
        transform.Find("Cylinder").GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
