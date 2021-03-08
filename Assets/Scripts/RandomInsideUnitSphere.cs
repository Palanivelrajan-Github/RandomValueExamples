using UnityEngine;

[ExecuteInEditMode]
public class RandomInsideUnitSphere : MonoBehaviour
{
    private void OnEnable()
    {
        // Sets the position to be somewhere inside a sphere
        // with radius 5 and the center at local position.
        transform.Find("Cube").localPosition = Random.insideUnitSphere * 5;
    }
}