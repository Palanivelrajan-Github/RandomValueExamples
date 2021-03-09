using UnityEngine;
using Random = UnityEngine.Random;

public class RandomRotationUniform : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "Rotate!"))
        {
            transform.Find("Cube").rotation = Random.rotationUniform;
        }
    }
}
